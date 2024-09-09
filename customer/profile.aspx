<%@ Page Title="" Language="C#" MasterPageFile="~/customer/header.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Sport.customer.profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-wrapper">
        <!-- End .header -->

        <main class="main">
            <div class="page-header text-center" style="background-image: url('assets/images/page-header-bg.jpg')">
                <div class="container">
                    <h1 class="page-title">PROFILE<span></span></h1>
                </div>
                <!-- End .container -->
            </div>
            <!-- End .page-header -->
          
            <!-- End .breadcrumb-nav -->

            <div class="page-content">
                <div class="checkout">
                    <div class="container">
                        
                            <div class="row">

                                <div class="col-lg-9">
                                    <h2 class="checkout-title">User Details</h2>
                                    <!-- End .checkout-title -->
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <label>Name</label>
                                            <asp:TextBox ID="name"  class="form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <!-- End .col-sm-6 -->


                                    </div>
                                    <!-- End .row -->





                                    <label>Street address *</label>
                                    <asp:TextBox ID="address"  class="form-control" runat="server"></asp:TextBox>

                                    <div class="row">
                                        <div class="col-sm-6">
                                            <label>Town / City *</label>
                                            <asp:TextBox ID="city"  class="form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <!-- End .col-sm-6 -->

                                        <div class="col-sm-6">
                                            <label>State</label>
                                            <asp:TextBox ID="state" class="form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <!-- End .col-sm-6 -->
                                    </div>
                                    <!-- End .row -->

                                    <div class="row">
                                        <div class="col-sm-6">
                                            <label>Postcode / ZIP *</label>
                                            <asp:TextBox ID="pincode" class="form-control" MinLength="6" MaxLength="6" runat="server"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="pincode" ForeColor="Red" ErrorMessage="Invalid Pin code" ValidationExpression="[1-9][0-9]{5}"></asp:RegularExpressionValidator>
                                            
                                        </div>
                                        <!-- End .col-sm-6 -->

                                        <div class="col-sm-6">
                                            <label>Phone *</label>
                                            <asp:TextBox ID="phone"  class="form-control" runat="server"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="REFmoblie" runat="server" ErrorMessage="Invalid Phone number" ControlToValidate="phone" ForeColor="Red" ValidationExpression="^[6-9][0-9]{9}$"></asp:RegularExpressionValidator>
                                        </div>
                                        <!-- End .col-sm-6 -->
                                    </div>
                                    <!-- End .row -->

                                    <label>Email address *</label>
                                   <asp:TextBox ID="email"  class="form-control" ReadOnly="true" runat="server" ></asp:TextBox>
                                </div>
                                <!-- End .col-lg-9 -->
                                       
                                <!-- End .col-lg-3 -->
                            </div>
                            <!-- End .row -->
                        <asp:LinkButton ID="update" class="btn btn-outline-primary-2" runat="server" OnClick="update_Click">
			                					<span>UPDATE</span>
			            						<%--<i class="icon-long-arrow-right"></i>--%>
                    </asp:LinkButton>
                    </div>
                    <!-- End .container -->
                </div>
                <!-- End .checkout -->
            </div>
            <!-- End .page-content -->
        </main>
        <!-- End .main -->

        <!-- End .footer -->
    </div>
</asp:Content>
