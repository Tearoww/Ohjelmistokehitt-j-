using Npgsql;
using System;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class DatabaseConnection
    {
        NpgsqlConnection connection;
        string connectionString;
        NpgsqlCommand cmd;

        /// <summary>
        /// Establishes a connection to the database
        /// </summary>
        /// <returns>True if connection was successful, otherwise false</returns>
        public async Task<bool> Connect()
        {
            connectionString = "Host=localhost;Username=postgres;Password=schooldatabases;Database=tic_tac_toe";
            connection = new NpgsqlConnection(connectionString);

            try
            {
                await connection.OpenAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Errors:" + e);
                connection.Close();
                return false;
            }
        }

        /// <summary>
        /// Disconnects from the database
        /// </summary>
        /// <returns></returns>
        public async Task Disconnect()
        {
            await connection.CloseAsync();
        }

        /// <summary>
        /// Tries to select a player from the database with given nickname and password
        /// </summary>
        /// <param name="nickname"></param>
        /// <param name="password"></param>
        /// <returns>A Player object or an error string</returns>
        public async Task<(Player, string)> Login(string nickname, string password)
        {
            if (await Connect())
            {
                Player player = new();

                bool playerFound = false, passwordCorrect = false;

                await using (cmd = new(
                    "SELECT * FROM public.players WHERE nickname = $1", connection))
                {
                    cmd.Parameters.AddWithValue(nickname);
                    await using var reader = await cmd.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        // This code is only reached if the nickname is found in the database
                        playerFound = true;
                        player.Id = reader.GetInt32(0);
                        player.Nickname = reader.GetString(1);
                    }
                }

                // Try to match both only if the nickname was found, otherwise we couldn't tell the user which was incorrect.
                if (playerFound)
                {
                    await using (cmd = new(
                        "SELECT * FROM public.players WHERE nickname = $1 AND password = $2", connection))
                    {
                        cmd.Parameters.AddWithValue(player.Nickname);
                        cmd.Parameters.AddWithValue(password);

                        await using var reader = await cmd.ExecuteReaderAsync();

                        while (await reader.ReadAsync())
                        {
                            // This code is only reached if given password is a match
                            passwordCorrect = true;
                            player.Password = reader.GetString(2);
                        }
                    }

                    if (passwordCorrect)
                    {
                        return (player, "all good");
                    }
                    else
                    {
                        return (null, "Incorrect password, try again!");
                    }
                }
                else
                {
                    await Disconnect();

                    return (null, "Couldn't find nickname, please try again.");
                }
            }
            else
            {
                await Disconnect();

                return (null, "Database couldn't be reached");
            }
        }

        /// <summary>
        /// Searches and, if not found, inserts the given nickname and password to the database
        /// </summary>
        /// <param name="nickname"></param>
        /// <param name="password"></param>
        /// <returns>An error string</returns>
        public async Task<string> Register(string nickname, string password)
        {
            if (await Connect())
            {
                bool nicknameTaken = false;

                await using (cmd = new(
                    "SELECT * FROM public.players WHERE nickname = $1", connection))
                {
                    cmd.Parameters.AddWithValue(nickname);
                    await using var reader = await cmd.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        // This code is only reached if the nickname is found in the database
                        nicknameTaken = true;
                    }
                }

                if (nicknameTaken == false)
                {
                    await using (cmd = new(
                        "INSERT INTO public.players (nickname, password) VALUES ($1, $2)", connection))
                    {
                        cmd.Parameters.AddWithValue(nickname);
                        cmd.Parameters.AddWithValue(password);

                        if (await cmd.ExecuteNonQueryAsync() != -1)
                        {
                            await Disconnect();

                            return "all good";
                        }
                        else
                        {
                            await Disconnect();

                            return "Couldn't register player. Please try again.";
                        }
                    }
                }
                else
                {
                    await Disconnect();

                    return "Nickname already taken!";
                }
            }
            else
            {
                return "Database couldn't be reached.";
            }
        }

        /// <summary>
        /// Updates, and if failed, inserts the player's highscore into the database
        /// </summary>
        /// <param name="score"></param>
        /// <param name="player"></param>
        /// <returns>An error string</returns>
        public async Task<string> SaveHighscore(int score, Player player)
        {
            // Yes, the author is aware that the player will only get a draw at best.
            int rowsAffected;

            if (await Connect())
            {
                await using (cmd = new(
                    "UPDATE public.scores SET highscore = $1 WHERE player_id = $2", connection))
                {
                    cmd.Parameters.AddWithValue(score);
                    cmd.Parameters.AddWithValue(player.Id);

                    // This actually returns the number of rows affected
                    rowsAffected = await cmd.ExecuteNonQueryAsync();
                }

                if (rowsAffected == 0)
                {
                    await using (cmd = new(
                        "INSERT INTO public.scores (highscore) VALUES ($1) WHERE player_id = $2", connection))
                    {
                        cmd.Parameters.AddWithValue(score);
                        cmd.Parameters.AddWithValue(player.Id);
                    }

                    return "all good";
                }
                else if (rowsAffected != -1)
                {
                    return "all good";
                }
                else
                {
                    return "Couldn't save highscore.";
                }
            }
            else
            {
                await Disconnect();

                return "Database couldn't be reached.";
            }
        }
    }
}
