<%@ Page Title="" Language="C#" MasterPageFile="~/customer/header.Master" AutoEventWireup="true" CodeBehind="wishlist.aspx.cs" CodeFile="wishlist.aspx.cs" Inherits="Sport.customer.wishlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <main class="main">
        	<div class="page-header text-center" style="background-image: url('assets/images/page-header-bg.jpg')">
        		<div class="container">
        			<h1 class="page-title">Wishlist<span>Shop</span></h1>
        		</div><!-- End .container -->
        	</div><!-- End .page-header -->
            <nav aria-label="breadcrumb" class="breadcrumb-nav">
                <div class="container">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="index.aspx">Home</a></li>
                        <li class="breadcrumb-item"><a href="prod.aspx">Shop</a></li>
                        <li class="breadcrumb-item active" aria-current="page">Wishlist</li>
                    </ol>
                </div><!-- End .container -->
            </nav><!-- End .breadcrumb-nav -->

            <div class="page-content">
            	<div class="container">
					<table class="table table-wishlist table-mobile">
						<asp:Repeater ID="rpt" runat="server">
							<HeaderTemplate>
							

						<tbody></HeaderTemplate><ItemTemplate>
							
							<tr>
								<td class="product-col">
									<div class="product">
										<figure class="product-media">
											<a href="#">
												<img src=<%# Eval("image1") %> alt="Product image">
											</a>
										</figure>

										<h3 class="product-title">
											<a href="#"><%# Eval("p_name") %></a>
										</h3><!-- End .product-title -->
									</div><!-- End .product -->
								</td>
								<td class="price-col"><%# Eval("price") %></td>
								
								<td class="action-col">
								<a href="inner.aspx?id=<%# Eval("product_id") %>" class="btn btn-block btn-outline-primary-2">ADD TO CART</a>
<%--	<button class="btn btn-block btn-outline-primary-2"><i class="icon-cart-plus"></i>Add to Cart</button>
							--%>	</td>
								<td><a href='WebForm2.aspx?id=<%# Eval("wish_id") %>'><i class="icon-close"></i></td>
									<td><a>In Stock</a></td>
							</tr>
							</ItemTemplate>
	<FooterTemplate>						</tbody>
					</FooterTemplate>
	</asp:Repeater>
											
						
						
						
						
						<asp:Repeater ID="Repeater1" runat="server">
							<HeaderTemplate>
							<thead>
							<tr>
								<th>Product</th>
								<th>Price</th>
								
								<th></th>
								<th></th>
							</tr>
						</thead>

						<tbody></HeaderTemplate><ItemTemplate>
							
							<tr>
								<td class="product-col">
									<div class="product">
										<figure class="product-media">
											<a href="#">
												<img src=<%# Eval("image1") %> alt="Product image">
											</a>
										</figure>

										<h3 class="product-title">
											<a href="#"><%# Eval("p_name") %></a>
										</h3><!-- End .product-title -->
									</div><!-- End .product -->
								</td>
								<td class="price-col"><%# Eval("price") %></td>
								
							
								<td><a href='WebForm2.aspx?id=<%# Eval("wish_id") %>'><i class="icon-close"></i></td>
								<td><a>Out Of Stock</a></td>
							</tr>
							</ItemTemplate>
	<FooterTemplate>						</tbody>
					</FooterTemplate>
	</asp:Repeater>

					</table><!-- End .table table-wishlist -->
	            	<div class="wishlist-share">
	            		<div class="social-icons social-icons-sm mb-2">
	            			<label class="social-label">Share on:</label>
	    					<a href="#" class="social-icon" title="Facebook" target="_blank"><i class="icon-facebook-f"></i></a>
	    					<a href="#" class="social-icon" title="Twitter" target="_blank"><i class="icon-twitter"></i></a>
	    					<a href="#" class="social-icon" title="Instagram" target="_blank"><i class="icon-instagram"></i></a>
	    					<a href="#" class="social-icon" title="Youtube" target="_blank"><i class="icon-youtube"></i></a>
	    					<a href="#" class="social-icon" title="Pinterest" target="_blank"><i class="icon-pinterest"></i></a>
	    				</div><!-- End .soial-icons -->
	            	</div><!-- End .wishlist-share -->
            	</div><!-- End .container -->
            </div><!-- End .page-content -->
        </main><!-- End .main -->

</asp:Content>
