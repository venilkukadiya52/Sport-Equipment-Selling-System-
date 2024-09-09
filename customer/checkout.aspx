<%@ Page Title="" Language="C#" MasterPageFile="~/customer/header.Master" AutoEventWireup="true" enableEventValidation="false" CodeBehind="checkout.aspx.cs" CodeFile="checkout.aspx.cs" Inherits="Sport.customer.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="page-wrapper">
        <!-- End .header -->

        <main class="main">
        	<div class="page-header text-center" style="background-image: url('assets/images/page-header-bg.jpg')">
        		<div class="container">
        			<h1 class="page-title">Checkout<span>Shop</span></h1>
        		</div><!-- End .container -->
        	</div><!-- End .page-header -->
            <nav aria-label="breadcrumb" class="breadcrumb-nav">
                <div class="container">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="index.html">Home</a></li>
                        <li class="breadcrumb-item"><a href="#">Shop</a></li>
                        <li class="breadcrumb-item active" aria-current="page">Checkout</li>
                    </ol>
                </div><!-- End .container -->
            </nav><!-- End .breadcrumb-nav -->

            <div class="page-content">
            	<div class="checkout">
	                <div class="container">
            			<form action="#">
		                	<div class="row">
		                		<div class="col-lg-9">
		                			<h2 class="checkout-title">Billing Details</h2><!-- End .checkout-title -->
		                				<div class="row">
		                					<div class="col-sm-6">
		                						<label>First Name *</label>
		                						 <asp:TextBox ID="name"  class="form-control" runat="server" required=""></asp:TextBox>
		                					</div><!-- End .col-sm-6 -->

		      
		                				</div><!-- End .row -->

	            					

	            						

	            						<label>Street address *</label>
	            					<asp:TextBox ID="address"  class="form-control" runat="server" required=""></asp:TextBox>

	            						<div class="row">
		                					<div class="col-sm-6">
		                						<label>Town / City *</label>
		                						  <asp:TextBox ID="city"  class="form-control" runat="server" required=""></asp:TextBox>
                                      
		                					</div><!-- End .col-sm-6 -->

		                					<div class="col-sm-6">
		                						<label>State / County *</label>
		                						<asp:TextBox ID="state" class="form-control" runat="server"></asp:TextBox>
		                					</div><!-- End .col-sm-6 -->
		                				</div><!-- End .row -->

		                				<div class="row">
		                					<div class="col-sm-6">
		                						<label>Postcode / ZIP *</label>
		                						<asp:TextBox ID="pincode" class="form-control" runat="server" required=""></asp:TextBox>
												 <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                                ControlToValidate="pincode" ForeColor="Red" ErrorMessage="Invalid Pin code"
                                                ValidationExpression="[1-9][0-9]{5}"></asp:RegularExpressionValidator>
                                      
		                					</div><!-- End .col-sm-6 -->

		                					<div class="col-sm-6">
		                						<label>Phone *</label>
		                						 <asp:TextBox ID="phone"  class="form-control" runat="server" required=""></asp:TextBox>
												 <asp:RegularExpressionValidator ID="REFmoblie" runat="server" ErrorMessage="Invalid Phone number" ControlToValidate="phone" ForeColor="Red" ValidationExpression="^[7-9][0-9]{9}$"></asp:RegularExpressionValidator>
		                					</div><!-- End .col-sm-6 -->
		                				</div><!-- End .row -->

	                					<label>Email address *</label>
	        						  <asp:TextBox ID="email"  class="form-control" runat="server" ReadOnly="true" required=""></asp:TextBox>

	        						<%--	 <asp:LinkButton ID="update" class="btn btn-outline-primary-2" runat="server" OnClick="update_Click">
			                					<span>UPDATE</span>
			            						<%--<i class="icon-long-arrow-right"></i>
                    </asp:LinkButton>--%>


	                				</div><!-- End .col-lg-9 -->
		                		<aside class="col-lg-3">
		                			<div class="summary">
		                				<h3 class="summary-title">Your Order</h3><!-- End .summary-title -->
										
		                				<table class="table table-summary">
		                					<thead>
		                						<tr>
		                							<th>Product</th>
		                							<th>Total</th>
		                						</tr>
		                					</thead>

		                					<tbody>
												<asp:Repeater ID="rpt" runat="server">
													<ItemTemplate>
		                						<tr>
		                							<td><a href="#"><%# Eval("p_name") %></a></td>
		                							<td><%# Eval("total") %></td>
		                						</tr>
</ItemTemplate>
		                						</asp:Repeater>
		                						<tr class="summary-subtotal">
		                							<td>Subtotal:</td>
		                							<td><asp:Label ID="Label1" runat="server"></asp:Label></td>
		                						</tr><!-- End .summary-subtotal -->
		                						<tr>
		                							<td>Shipping:</td>
		                							<td>Free shipping</td>
		                						</tr>
		                						<tr class="summary-total">
		                							<td>Total:</td>
		                							<td><asp:Label ID="total" runat="server"></asp:Label></td>
		                						</tr><!-- End .summary-total -->
		                					</tbody>
		                				</table><!-- End .table table-summary -->

		                				<div class="accordion-summary" id="accordion-payment">
										    <div class="card">
										        <div class="card-header" id="heading-1">
										            <h2 class="card-title">
										                <a role="button" data-toggle="collapse" href="#collapse-1" aria-expanded="true" aria-controls="collapse-1">
										                    Direct bank transfer
										                </a>
										            </h2>
										        </div><!-- End .card-header -->
										        <div id="collapse-1" class="collapse show" aria-labelledby="heading-1" data-parent="#accordion-payment">
										            <div class="card-body">
										                Make your payment directly into our bank account. Please use your Order ID as the payment reference. Your order will not be shipped until the funds have cleared in our account.
										            </div><!-- End .card-body -->
										        </div><!-- End .collapse -->
										    </div><!-- End .card -->

										    <div class="card">
										        <div class="card-header" id="heading-2">
										            <h2 class="card-title">
										                <a class="collapsed" role="button" data-toggle="collapse" href="#collapse-2" aria-expanded="false" aria-controls="collapse-2">
										                    Check payments
										                </a>
										            </h2>
										        </div><!-- End .card-header -->
										        <div id="collapse-2" class="collapse" aria-labelledby="heading-2" data-parent="#accordion-payment">
										            <div class="card-body">
										                Ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque volutpat mattis eros. Nullam malesuada erat ut turpis. 
										            </div><!-- End .card-body -->
										        </div><!-- End .collapse -->
										    </div><!-- End .card -->

										    <div class="card">
										        <div class="card-header" id="heading-3">
										            <h2 class="card-title">
										                <a class="collapsed" role="button" data-toggle="collapse" href="#collapse-3" aria-expanded="false" aria-controls="collapse-3">
										                    Cash on delivery
										                </a>
										            </h2>
										        </div><!-- End .card-header -->
										        <div id="collapse-3" class="collapse" aria-labelledby="heading-3" data-parent="#accordion-payment">
										            <div class="card-body">Quisque volutpat mattis eros. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque volutpat mattis eros. 
										            </div><!-- End .card-body -->
										        </div><!-- End .collapse -->
										    </div><!-- End .card -->

										    <div class="card">
										        <div class="card-header" id="heading-4">
										            <h2 class="card-title">
										                <a class="collapsed" role="button" data-toggle="collapse" href="#collapse-4" aria-expanded="false" aria-controls="collapse-4">
										                    PayPal <small class="float-right paypal-link">What is PayPal?</small>
										                </a>
										            </h2>
										        </div><!-- End .card-header -->
										        <div id="collapse-4" class="collapse" aria-labelledby="heading-4" data-parent="#accordion-payment">
										            <div class="card-body">
										                Nullam malesuada erat ut turpis. Suspendisse urna nibh, viverra non, semper suscipit, posuere a, pede. Donec nec justo eget felis facilisis fermentum.
										            </div><!-- End .card-body -->
										        </div><!-- End .collapse -->
										    </div><!-- End .card -->

										    <div class="card">
										        <div class="card-header" id="heading-5">
										            <h2 class="card-title">
										                <a class="collapsed" role="button" data-toggle="collapse" href="#collapse-5" aria-expanded="false" aria-controls="collapse-5">
										                    Credit Card (Stripe)
										                    <img src="assets/images/payments-summary.png" alt="payments cards">
										                </a>
										            </h2>
										        </div><!-- End .card-header -->
										        <div id="collapse-5" class="collapse" aria-labelledby="heading-5" data-parent="#accordion-payment">
										            <div class="card-body"> Donec nec justo eget felis facilisis fermentum.Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque volutpat mattis eros. Lorem ipsum dolor sit ame.
										            </div><!-- End .card-body -->
										        </div><!-- End .collapse -->
										    </div><!-- End .card -->
										</div><!-- End .accordion -->


										<asp:Button ID="btncheckout" runat="server" Text="Place Order" OnClick="btncheckout_Click" />
										<asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />

										<%--<asp:LinkButton ID="check" runat="server" OnCommand="check_Command">PLACE ORDER</asp:LinkButton>
		                				--%><%--<button type="submit" class="btn btn-outline-primary-2 btn-order btn-block">
		                					<span class="btn-text">Place Order</span>
		                					<span class="btn-hover-text">Proceed to Checkout</span>
		                				</button>--%>
		                			</div><!-- End .summary -->
		                		</aside><!-- End .col-lg-3 -->
		                	</div><!-- End .row -->
            			</form>
	                </div><!-- End .container -->
                </div><!-- End .checkout -->
            </div><!-- End .page-content -->
        </main><!-- End .main -->

        <!-- End .footer -->
    </div>
</asp:Content>
