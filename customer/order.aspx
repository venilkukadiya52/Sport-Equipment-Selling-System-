<%@ Page Title="" Language="C#" MasterPageFile="~/customer/header.Master" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="Sport.customer.order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="main">
        	<div class="page-header text-center" style="background-image: url('assets/images/page-header-bg.jpg')">
        		<div class="container">
        			<h1 class="page-title">ORDER DETAILS<span>Shop</span></h1>
        		</div><!-- End .container -->
        	</div><!-- End .page-header -->
            <nav aria-label="breadcrumb" class="breadcrumb-nav">
                <div class="container">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="index.aspx">Home</a></li>
                        <li class="breadcrumb-item"><a href="prod.aspx">Shop</a></li>
                        <li class="breadcrumb-item active" aria-current="page">ORDER DETAILS</li>
                    </ol>
                </div><!-- End .container -->
            </nav><!-- End .breadcrumb-nav -->

            <div class="page-content">
            	<div class="cart">
	                <div class="container">
	                	<div class="row">
	                		<div class="col-lg-9">
									<asp:Repeater ID="Repeater1" runat="server"><HeaderTemplate>
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
											<td><p>PENDING</p></td>
<%--											<td><a href='feedback.aspx?id=<%# Eval("order_id") %>'>FEEDBACK</a></td>--%>
										</tr>
										<%--<asp:Label ID="status" runat="server" Text='<%# Eval("status") %>'></asp:Label>--%>
									</tbody></ItemTemplate><FooterTemplate>
								</table><!-- End .table table-wishlist -->
										
									</FooterTemplate>
								</asp:Repeater>
								<asp:Repeater ID="rpt" runat="server"><HeaderTemplate>
	                			<table class="table table-cart table-mobile">
									
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
											
<%--											<td><a href='feedback.aspx?id=<%# Eval("order_id") %>'>FEEDBACK</a></td>--%>
										</tr>
										<%--<asp:Label ID="status" runat="server" Text='<%# Eval("status") %>'></asp:Label>--%>
									</tbody></ItemTemplate><FooterTemplate>
								</table><!-- End .table table-wishlist -->
										
									</FooterTemplate>
								</asp:Repeater>	<!-- End .cart-bottom -->
								
	                		</div><!-- End .col-lg-9 -->
							
	                		<!-- End .col-lg-3 -->
	                	</div><!-- End .row -->
	                </div><!-- End .container -->
                </div><!-- End .cart -->
            </div><!-- End .page-content -->
        </main>
</asp:Content>
