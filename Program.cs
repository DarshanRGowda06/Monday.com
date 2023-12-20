using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;


namespace Monday
{
    public class Program
    {

        public static void Main()
        {
            string apiUrl = "https://api.monday.com/v2";
            Program program = new Program();

            #region WORKSPACE

            #region Get Workspace
            //string requestBody = "{\r\n   \"query\": \"query { workspaces { id name}}\" \r\n}";
            //string responseGetworkspace = program.CallHttp(apiUrl, requestBody);
            //Console.WriteLine(responseGetworkspace);
            #endregion

            #region Create Workspace
            //string workspacename = "demoworkspace";
            //string kind = "open";
            //string description = "this is demoworkspace1";
            //string querydata = $"mutation {{ create_workspace (name: \"{workspacename}\",kind: {kind}, description: \"{description}\") {{id description}}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseCreateworkspace = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateworkspace);
            #endregion

            #region Delete Workspace
            //string workspaceId = "259810";
            //string queryData = $"mutation {{ delete_workspace (workspace_id: {workspaceId}){{ id }} }}";
            //JObject obj = new JObject();
            //obj["query"] = queryData;
            //string jbody = obj.ToString();
            //string responseDeleteworkspace = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseDeleteworkspace);
            #endregion

            #endregion

            #region BOARD

            #region Get Board
            //string boardId = "1832588726";
            //string queryData = $"query {{ boards (ids: {boardId}) {{name state id permissions board_kind subscribers }} }}                                 ";
            //JObject obj = new JObject();
            //obj["query"] = queryData;
            //string jbody = obj.ToString();
            //string responseGetBoard = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseGetBoard);
            #endregion

            #region Create Board
            //string workspaceId = "259790";
            //string boardName = "newboard12";
            //string boardKind = "public";
            //string board_description = "abc";
            //string querydata = $"mutation {{ create_board (workspace_id :{workspaceId}, board_name: \"{boardName}\", board_kind: {boardKind},description :\"{board_description}\"){{id}}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();            
            //string responseCreateBoard = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateBoard);
            #endregion

            #region Update Board
            //string boardId = "259790";
            //string board_description = "abc";
            //string queryData = $"mutation {{ update_board( board_id: {boardId},board_attribute: description, new_value: \"{board_description}\")}}";
            //JObject obj = new JObject();
            //obj["query"] = queryData;
            //string jbody = obj.ToString();
            //string responseCreateBoard = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateBoard);
            #endregion

            #region Duplicate Board
            //string boardId = "259790";
            //string duplicate_type = "duplicate_board_with_structure"; 
            ////duplication type: duplicate_board_with_structure, duplicate_board_with_pulses,or duplicate_board_with_pulses_and_updates

            //string queryData = $"mutation {{duplicate_board(board_id: {boardId}, duplicate_type: {duplicate_type}) {{ board {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = queryData;
            //string jbody = obj.ToString();
            //string responseCreateBoard = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateBoard);

            #endregion

            #region Delete Board
            //string boardId = "259790";
            //string queryData = $"mutation {{delete_board(board_id: {boardId}) {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = queryData;
            //string jbody = obj.ToString();
            //string responseCreateBoard = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateBoard);

            #endregion

            #endregion

            #region GROUP

            #region Create Group
            //string boardId = "1832643093";
            //string group_name = "demogrp1";
            //string queryData = $"mutation {{ create_group (board_id: {boardId}, group_name: \"{group_name}\") {{ id }} }}";
            //JObject obj = new JObject();
            //obj["query"] = queryData;
            //string jbody = obj.ToString();
            //string responseCreateGroup = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateGroup);
            #endregion

            #region Delete Group
            //string boardId = "1832643093";
            //string group_id = "demogrp1";
            //string queryData = $"mutation {{ delete_group (board_id: {boardId}, group_name: \"{group_id}\") {{ id }} }}";
            //JObject obj = new JObject();
            //obj["query"] = queryData;
            //string jbody = obj.ToString();
            //string responseDeleteGroup = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseDeleteGroup);
            #endregion

            #region Get Groups
            //string boardId = "1832643093";
            //string queryData = $"query {{ boards(ids: {boardId}) {{ groups {{ title id }} }} }}";
            //JObject obj = new JObject();
            //obj["query"] = queryData;
            //string jbody = obj.ToString();
            //string responseGetGroup = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseGetGroup);
            #endregion

            #endregion

            #region  COLUMN

            #region Create Column
            //string boardId = "1832643093";
            //string title = "democol";
            //string description = "this is description";
            //string column_type = "rating";
            //string querydata = $"mutation {{create_column(board_id: {boardId}, title:\"{title}\", description: \"{description}\", column_type:{column_type}){{id title description}}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseCreateColumn = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateColumn);

            #endregion

            #region Create Status or dropdown column with custom label

            //string boardId = "1832643093";
            //string title = "democool";
            //string description = "this is description";
            //string column_type = "status";
            //string defaults = "{\\\"labels\\\":{\\\"1\\\": \\\"Information technology\\\", \\\"2\\\": \\\"Human resources\\\", \\\"3\\\": \\\"Customer service\\\", \\\"4\\\": \\\"Other\\\"}}";
            //string querydata = $"mutation {{ create_column(board_id: {boardId}, title:\"{title}\", column_type:{column_type}, description: \"{description}\", defaults: \"{defaults}\"){{id}}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseCreateStatusorDropdown = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateStatusorDropdown);

            #endregion

            #region Delete Column
            //string boardId = "1832643093";
            //string column_id = "democool";
            //string querydata = $"mutation {{ delete_column(board_id: {boardId}, column_id: \"{column_id}\") {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseDeleteColumn = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseDeleteColumn);
            #endregion

            #region Get Column
            //string boardId = "1832643093";
            //string querydata = $"query {{boards (ids: {boardId}) {{ columns {{ id title }}}}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseGetColumn = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseGetColumn);
            #endregion

            #endregion

            #region ITEM

            #region Create Item
            //string boardId = "1832643093";
            //string groupId = "demo";
            //string itemName = "demoitem";
            //string querydata = $"mutation {{create_item(board_id: {boardId}, group_id: \"{groupId}\", item_name: \"{itemName}\", column_values: \"{{\\\"text\\\":\\\"abDc\\\",\\\"work_status\\\":{{\\\"label\\\": \\\"Done\\\"}}}}\") {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseCreateBoard = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateBoard);
            #endregion

            #region Move Item to Group
            //string groupId = "demo";
            //string itemid = "demoitem";
            //string querydata = $"mutation {{move_item_to_group(item_id: {itemid}, group_id: \\\"{groupId}\\\") {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseMoveItemtoGroup = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseMoveItemtoGroup);
            #endregion

            #region Archive item
            //string itemid = "demoitem";
            //string querydata = $"mutation {{archive_item (item_id: {itemid}) {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseArchieveitem = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseArchieveitem);
            #endregion

            #region Delete Item
            //string itemid = "demoitem";
            //string querydata = $"mutation {{ delete_item (item_id: {itemid}) {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseDeleteItem = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseDeleteItem);
            #endregion

            #endregion

            #region UPDATES

            #region Create update

            //string body = "this is body";
            //string itemId = "demoitem";
            //string querydata = $"mutation {{create_update(item_id: {itemId}, body: \"{body}\") {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseCreateUpdate = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseCreateUpdate);
            #endregion

            #region Like an Update
            //string updateId = "demoitem";
            //string querydata = $"mutation {{ like_update (update_id: {updateId}) {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseLikeUpdate = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseLikeUpdate);
            #endregion

            #region Clear an Item Updates
            //string updateId = "demoitem";
            //string querydata = $"mutation {{clear_item_updates (item_id: {updateId}) {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseClearItemUpdate = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseClearItemUpdate);
            #endregion

            #region Delete Update
            //string updateId = "demoitem";
            //string querydata = $"mutation {{ delete_update (id: {updateId}) {{ id }}}}";
            //JObject obj = new JObject();
            //obj["query"] = querydata;
            //string jbody = obj.ToString();
            //string responseDeleteUpdate = program.CallHttp(apiUrl, jbody);
            //Console.WriteLine(responseDeleteUpdate);
            #endregion

            #endregion
        }

        #region CallHttp
        public string CallHttp(string apiUrl,string requestBody) 
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "eyJhbGciOiJIUzI1NiJ9.eyJ0aWQiOjMwMjgwNTUxMywiYWFpIjoxMSwidWlkIjo1MzIwNTYyMCwiaWFkIjoiMjAyMy0xMi0xNFQxMDo0Mzo0Ny4wMDBaIiwicGVyIjoibWU6d3JpdGUiLCJhY3RpZCI6MjAyOTU0NjgsInJnbiI6ImFwc2UyIn0.jmnuN0Gzfo34fgYKRaIJovr0WQ-LVQm2xsNylL4RZjA");
            byte[] requestBodyBytes = Encoding.UTF8.GetBytes(requestBody);
            request.ContentLength = requestBodyBytes.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(requestBodyBytes, 0, requestBodyBytes.Length);
            }
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string apiResponse = reader.ReadToEnd();
                    return apiResponse;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (Stream errorStream = ex.Response.GetResponseStream())
                    using (StreamReader errorReader = new StreamReader(errorStream))
                    {
                        string errorResponse = errorReader.ReadToEnd();
                        throw new DataException($"Error response: {errorResponse}");
                    }
                }
                else
                {
                    throw new DataException($"Request error: {ex.Message}");

                }
            }
        }
        #endregion

       
    }
}