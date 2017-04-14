<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<html>
    <head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script type="text/javascript">
        var $submit = false;
        var path = null;

        $(document).ready(function () {
            $("#cancel").click(function () {
                location.reload();
            });

            $("#btnUpload").click(function () {

                $.post("http://localhost:60637/UploadHandler.ashx", { path: path }, function (data) {
                    // Add extra line for deployment url
                    //var d = data.split(':');
                    var d = data;
                    alert(d);
                    //$("#res").html("File Name : " + d[0] + "<br/> Size : " + d[1] + "<br/>Type: " + d[2] + "<br/> : " + d[3]);
                });
            });

        });

        function show(e) {
            path = e.value;
        }

        //Read text file and preview data in a pop up box
        var openFile = function(event) {
            var input = event.target;
            var reader = new FileReader();
            reader.onload = function(){
                var text = reader.result;
                $("#submit").click(function(){
                  if(!$submit)
                  {
                    alert("First Name: \nLast Name: \nComments: ");
                    $("#submit").html('Submit');
                    $submit = true;
                  }
                  else{
                    $submit = false;
                    location.reload();
                  }
                });
            };
        reader.readAsText(input.files[0]);
      };
      

    </script>
    </head>
    <body>
    <form method="post" enctype="multipart/form-data" runat="server">
        <input type="file" id="file-select" onchange="show(this)"/>
        <input type="button" value="upload" id="btnUpload" class="btn" />
    </form>
    <button id="submit">Show Preview</button>
    <button id="cancel">Cancel</button>
    <div id="res"></div>

    </body>
</html>
