<%@ Page Title="" Language="C#" MasterPageFile="~/customer/header.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="Sport.customer.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<main class="main">
        	<div class="page-header text-center" style="background-image: url('assets/images/page-header-bg.jpg')">
        		<div class="container">
        			<h1 class="page-title">Shopping Cart<span>Shop</span></h1>
        		</div><!-- End .container -->
        	</div><!-- End .page-header -->
            <nav aria-label="breadcrumb" class="breadcrumb-nav">
                <div class="container">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="index.aspx">Home</a></li>
                        <li class="breadcrumb-item"><a href="prod.aspx">Shop</a></li>
                        </ol>
                </div><!-- End .container -->
            </nav><!-- End .breadcrumb-nav -->

            <div class="page-content">
            	<div class="cart">
	                <div class="container">
	                	<div class="row">
	                		<div class="col-lg-9">
								<asp:Repeater ID="rpt" runat="server"><HeaderTemplate>
	                			<table class="table table-cart table-mobile">
									<thead>
										<tr>
											<th>Product</th>
											<th>Price</th>
											<th>Quantity</th>
											<th>Total</th>
											<th></th>
										</tr>
									</thead>
</HeaderTemplate><ItemTemplate>
									<tbody>
										<tr>
											<td class="product-col">
												<div class="product">
													<figure class="product-media">
														<a href="#">
															<img src='<%# Eval("image1") %>'' alt="Product image">
														</a>
													</figure>

													<h3 class="product-title">
														<a href="#"><%# Eval("p_name") %></a>
													</h3><!-- End .product-title -->
												</div><!-- End .product -->
											</td>
											<td class="price-col"><%# Eval("price") %></td>
											<td class="quantity-col">
                                                <div class="cart-product-quantity"><asp:Label ID="qty"><%# Eval("quantity") %></asp:Label>
													
                                                </div><!-- End .cart-product-quantity -->
                                            </td>
											<td class="total-col"><%# Eval("total") %></td>
											<td><a href="update.aspx?id=<%# Eval("product_id") %>&i=<%# Eval("order_id") %>&price=<%# Eval("price") %>">Update</a></td>
											
											<td><a href='WebForm1.aspx?id=<%# Eval("order_id") %>'><i class="icon-close"></i></a></td>
										</tr>
										
									</tbody></ItemTemplate><FooterTemplate>
								</table><!-- End .table table-wishlist -->
										
									</FooterTemplate>
								</asp:Repeater>	<!-- End .cart-bottom -->
								<asp:Button ID="total" OnClick="total_Click" runat="server" Text="GRAND TOTAL" class="btn btn-outline-dark-2 icon-refresh" />

	                		</div><!-- End .col-lg-9 -->
							
	                		<aside class="col-lg-3">
	                			<div class="summary summary-cart">
	                				<h3 class="summary-title">Cart Total</h3><!-- End .summary-title -->

	                				<table class="table table-summary">
	                					<tbody>
	                						<tr class="summary-subtotal">
	                							<td>Subtotal:</td>
				      							<td><asp:Label ID="Lable1" runat="server"></asp:Label></td>
	                						</tr><!-- End .summary-subtotal -->
	                						<tr class="summary-shipping">
	                							<td>Shipping:</td>
	                							<td>&nbsp;</td>
	                						</tr>

	                						<tr class="summary-shipping-row">
	                							<td>
													<div class="custom-control custom-radio">
														<input type="radio" id="free-shipping" name="shipping" class="custom-control-input">
														<label class="custom-control-label" for="free-shipping">Free Shipping</label>
													</div><!-- End .custom-control -->
	                							</td>
	                							<td>₹00.00</td>
	                						</tr><!-- End .summary-shipping-row -->

	                						<tr class="summary-shipping-row">
	                							<td>
	                								<div class="custom-control custom-radio">
														<input type="radio" id="standart-shipping" name="shipping" class="custom-control-input">
														<label class="custom-control-label" for="standart-shipping">Standart:</label>
													</div><!-- End .custom-control -->
	                							</td>
	                							<td>₹00.00</td>
	                						</tr><!-- End .summary-shipping-row -->

	                						<tr class="summary-shipping-row">
	                							<td>
	                								<div class="custom-control custom-radio">
														<input type="radio" id="express-shipping" name="shipping" class="custom-control-input">
														<label class="custom-control-label" for="express-shipping">Express:</label>
													</div><!-- End .custom-control -->
	                							</td>
	                							<td>₹00.00</td>
	                						</tr><!-- End .summary-shipping-row -->

	                						<tr class="summary-shipping-estimate">
	                							<td>Estimate for Your Country<br> <a href="profile.aspx" >Change address</a></td>
	                							<td>&nbsp;</td>
	                						</tr><!-- End .summary-shipping-estimate -->

	                						<tr class="summary-total">
	                							<td>Total:</td>
	                							<td><asp:Label ID="Lable2" runat="server"></asp:Label></td>
	                						</tr><!-- End .summary-total -->
	                					</tbody>
	                				</table><!-- End .table table-summary -->

	                				<a href="checkout.aspx" class="btn btn-outline-primary-2 btn-order btn-block">PROCEED TO CHECKOUT</a>
	                			</div><!-- End .summary -->

		            			<a href="prod.aspx" class="btn btn-outline-dark-2 btn-block mb-3"><span>CONTINUE SHOPPING</span><i class="icon-refresh"></i></a>
	                		</aside><!-- End .col-lg-3 -->
	                	</div><!-- End .row -->
	                </div><!-- End .container -->
                </div><!-- End .cart -->
            </div><!-- End .page-content -->
        </main><!-- End .main -->

		

</asp:Content>
