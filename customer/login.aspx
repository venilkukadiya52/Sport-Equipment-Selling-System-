<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" CodeFile="login.aspx.cs"  Inherits="Sport.customer.login" %>
<!DOCTYPE html>
<html lang="en">


<!-- molla/login.html  22 Nov 2019 10:04:03 GMT -->
<head>
    <script type="text/javascript">
        function preventback() {window.history.forward();}
            setTimeout("preventback()", 0);
            window.onunload = function () { null };


        </script>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Molla - Bootstrap eCommerce Template</title>
    <meta name="keywords" content="HTML5 Template">
    <meta name="description" content="Molla - Bootstrap eCommerce Template">
    <meta name="author" content="p-themes">
    <!-- Favicon -->
    <link rel="apple-touch-icon" sizes="180x180" href="assets/images/icons/apple-touch-icon.png">
    <link rel="icon" type="image/png" sizes="32x32" href="assets/images/icons/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="assets/images/icons/favicon-16x16.png">
    <link rel="manifest" href="assets/images/icons/site.html">
    <link rel="mask-icon" href="assets/images/icons/safari-pinned-tab.svg" color="#666666">
    <link rel="shortcut icon" href="assets/images/icons/favicon.ico">
    <meta name="apple-mobile-web-app-title" content="Molla">
    <meta name="application-name" content="Molla">
    <meta name="msapplication-TileColor" content="#cc9966">
    <meta name="msapplication-config" content="assets/images/icons/browserconfig.xml">
    <meta name="theme-color" content="#ffffff">
    <!-- Plugins CSS File -->
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <!-- Main CSS File -->
    <link rel="stylesheet" href="assets/css/style.css">
</head>

<body>
    <div class="page-wrapper">
            <!-- End .header -->
        <form method="post" runat="server">
        <main class="main">
            <nav aria-label="breadcrumb" class="breadcrumb-nav border-0 mb-0">
                <div class="container">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="index.aspx">Home</a></li>
                        
                        <li class="breadcrumb-item active" aria-current="page">Login</li>
                    </ol>
                </div><!-- End .container -->
            </nav><!-- End .breadcrumb-nav -->

            <div class="login-page bg-image pt-8 pb-8 pt-md-12 pb-md-12 pt-lg-17 pb-lg-17" style="background-image: url('assets/images/backgrounds/login-bg.jpg')">
            	<div class="container">
            		<div class="form-box">
            			<div class="form-tab">
	            			<ul class="nav nav-pills nav-fill" role="tablist">
							    <li class="nav-item">
							        <a class="nav-link" id="signin-tab-2" data-toggle="tab" href="#signin-2" role="tab" aria-controls="signin-2" aria-selected="false">Sign In</a>
							    </li>
							    <li class="nav-item">
							        <a class="nav-link active" id="register-tab-2" data-toggle="tab" href="#register-2" role="tab" aria-controls="register-2" aria-selected="true">Register</a>
							    </li>
							</ul>
							<div class="tab-content">
        <div class="tab-pane fade" id="signin-2" role="tabpanel" aria-labelledby="signin-tab-2">

            <div class="form-group">
                <label for="singin-email-2">Email address *</label>
                <asp:TextBox TextMode="SingleLine" class="form-control" ID="username" runat="server" required=""></asp:TextBox>
            </div>
            <!-- End .form-group -->

            <div class="form-group">
                <label for="singin-password-2">Password *</label>
                <asp:TextBox TextMode="Password" class="form-control" ID="pass" runat="server" required=""></asp:TextBox>
            </div>
            <!-- End .form-group -->

            <div class="form-footer">
                <asp:LinkButton ID="login_ch" class="btn btn-outline-primary-2" runat="server" OnClick="login_Clicked">
			                					<span>Login</span>
			            						<i class="icon-long-arrow-right"></i>
                </asp:LinkButton>   


                <!-- End .custom-checkbox -->

                <a href="forgetpassword.aspx" class="forgot-link">Forgot Your Password?</a>
            </div>
            <!-- End .form-footer -->


            <!-- End .row -->
            <!-- End .form-choice -->
        </div>
        <!-- .End .tab-pane -->
        <div class="tab-pane fade show active" id="register-2" role="tabpanel" aria-labelledby="register-tab-2">

            <div class="form-group">
                <label for="register-email-2">Your email address *</label>
                <asp:TextBox ID="email" class="form-control" runat="server" TextMode="Email" required=""></asp:TextBox>
            </div>
            <!-- End .form-group -->

            <div class="form-group">
                <label for="register-password-2">Name *</label>
                <asp:TextBox ID="name" class="form-control" TextMode="SingleLine" runat="server" required=""></asp:TextBox>
                <asp:RegularExpressionValidator ID="rfvFname" runat="server" ControlToValidate="name" ForeColor="Red" ErrorMessage="Only Charater" ValidationExpression="^([A-z][A-Za-z]*\s*[A-Za-z]*)$"></asp:RegularExpressionValidator>
            </div>
           
            <!-- End .form-group -->



            <div>
                <asp:Label ID="Error" runat="server"></asp:Label>
            </div>


            <div class="form-footer">
            
                <asp:LinkButton ID="sendotp" class="btn btn-outline-primary-2" runat="server" OnClick="sendotp_Click">
			                					<span>SEND OTP</span>
			            						<i class="icon-long-arrow-right"></i>
                </asp:LinkButton>


                <div class="form-group">
                    <asp:TextBox ID="otp" class="form-control" placeholder="Enter OTP" runat="server" TextMode="SingleLine" required=""></asp:TextBox>
                </div>

                <div class="form-footer">
                    <asp:LinkButton ID="verify" class="btn btn-outline-primary-2" runat="server" OnClick="verify_Click">
			                					<span>VERIFY</span>
			            						<i class="icon-long-arrow-right"></i>
                    </asp:LinkButton>
                </div>
                <div class="form-group">
                    <br>
                    <asp:TextBox ID="password" class="form-control" placeholder="Password" TextMode="Password" runat="server" required=""></asp:TextBox>
                </div>
                <asp:LinkButton ID="register" class="btn btn-outline-primary-2" runat="server" OnClick="register_Click">
			                					<span>REGISTER</span>
			            						<i class="icon-long-arrow-right"></i>
                </asp:LinkButton>
                <!-- End .custom-checkbox -->
            </div>
            <!-- End .form-footer -->

            <!-- End .form-choice -->
        </div>
        <!-- .End .tab-pane -->
    </div><!-- End .tab-content -->
						</div><!-- End .form-tab -->
            		</div><!-- End .form-box -->
            	</div><!-- End .container -->
            </div><!-- End .login-page section-bg -->
        </main><!-- End .main -->
        </form>
        <!-- End .footer -->
    </div><!-- End .page-wrapper -->
    <button id="scroll-top" title="Back to Top"><i class="icon-arrow-up"></i></button>

    <!-- Mobile Menu -->
    <div class="mobile-menu-overlay"></div><!-- End .mobil-menu-overlay -->

    <!-- End .mobile-menu-container -->

    <!-- Sign in / Register Modal -->
    <!-- End .modal -->

    <!-- Plugins JS File -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/bootstrap.bundle.min.js"></script>
    <script src="assets/js/jquery.hoverIntent.min.js"></script>
    <script src="assets/js/jquery.waypoints.min.js"></script>
    <script src="assets/js/superfish.min.js"></script>
    <script src="assets/js/owl.carousel.min.js"></script>
    <!-- Main JS File -->
    <script src="assets/js/main.js"></script>
</body>


<!-- molla/login.html  22 Nov 2019 10:04:03 GMT -->
</html>