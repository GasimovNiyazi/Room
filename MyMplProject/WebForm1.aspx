<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyMplProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Room</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">

        <!-- jQuery library -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

        <!-- Latest compiled JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style> 
            .form-content {
                padding: 5%;
                background:#ff0000;
                margin-bottom: 2%;
            }
            
            .form-control {
                border-radius: 0.5rem;
            }
           
            .btnSubmit {
                border: none;
                border-radius: 0.5rem;
                padding: 1%;
                
                cursor: pointer;
                background: #ffffff;
                color: #808080;
                width: 20%;

margin-right: 10%;
            }
        </style>
</head>
<body>
   <form id="form1" runat="server">

            <div class="container register-form">
                <div class="form">
                    <div class="form-content">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <input type="text" id="length" class="form-control" placeholder="Length" value="" runat="server" />
                                </div>
                                 <div class="form-group">
                                    <input type="text" class="form-control" id="width" placeholder="Width" value="" runat="server" />
                                </div>
                                <div class="form-group">
                                    <select class="form-control" id="floorType" runat="server" >


                                    </select>
                                </div>
                                 <div class="form-group">
                                    <select class="form-control" id="color" runat="server">

                                        

                                    </select>
                                </div>

                               
                                <div class="form-group">
                                    <select class="form-control" id="employee" runat="server">

                                        

                                    </select>
                                    
                                </div>
                               
                            
                            </div>
                            <div class="col-md-6">
                               <div class="form-group">
                                 
                                    <label class="form-control" id="floorPrice" runat="server">Material Price: </label>
                                </div>
                                   <div class="form-group">
                                    
                                        <label class="form-control" id="colorPrice" runat="server">Color Price: </label>
                                </div>
                                 
                                    

                                  
                                <div class="form-group">
                                     <label class="form-control" id="salary" runat="server">Salary: </label>
                                </div>
                                <div class="form-group">
                                     <label class="form-control" id="result" runat="server">Result:</label>
                                </div>
                            </div>
                        </div>
                        <asp:Button id="button1" runat="server" class="btnSubmit" Text="Calculate" OnClick="button1_Click" />
                        
                    </div>
                </div>
            </div>
        </form>
</body>
</html>
