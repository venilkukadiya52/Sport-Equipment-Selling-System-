<%@ Page Title="" Language="C#" MasterPageFile="~/customer/header.Master" AutoEventWireup="true" CodeBehind="prod.aspx.cs" CodeFile="prod.aspx.cs" Inherits="Sport.customer.prod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

 
    
        <div class="page-wrapper">

            <main class="main">
                <!-- End .page-header -->
                <nav aria-label="breadcrumb" class="breadcrumb-nav mb-2">
                    <div class="container-fluid">
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="index.aspx">Home</a></li>
                            <li class="breadcrumb-item"><a href="product.aspx">Shop</a></li>

                        </ol>
                            
                    </div>

                    <!-- End .container-fluid -->
                </nav>
                <!-- End .breadcrumb-nav -->

                <div class="page-content">
                    <div class="container-fluid">
                        <div class="toolbox">
                            <div class="toolbox-left">
                            </div>
                            <!-- End .toolbox-left -->

                            <div class="toolbox-center">
                                <div class="toolbox-info">
                                   
                           
                                </div>
                                <!-- End .toolbox-info -->
                            </div>
                            <!-- End .toolbox-center -->

                            <div class="toolbox-right">
                                <div class="toolbox-sort">
                                    <label for="sortby">Sort by:</label>
                                    <div class="select-custom">
                                       
                                    </div>
                                </div>
                                <!-- End .toolbox-sort -->
                            </div>
                            <!-- End .toolbox-right -->
                        </div>
                        <!-- End .toolbox -->
                       <asp:Repeater ID="Repeater1" runat="server" >
                                              <HeaderTemplate>       
                            <div class="products">
                            
                                        <div class="row">
											</HeaderTemplate>   <ItemTemplate>
                                            <div class="col-6 col-md-4 col-lg-4 col-xl-3 col-xxl-2">
                                                <div class="product">
                                                     
                                                      <figure class="product-media">
                                                     
                                                        <a href="inner.aspx?id=<%# Eval("product_id") %>">
                                                            <img src='<%# Eval("image1") %>' alt="Product image" class="product-image"'>
                                                        </a>
                                                        
                                                        <div class="product-action-vertical">
                                                            <a href="#" class="btn-product-icon btn-wishlist btn-expandable"><span>add to wishlist</span></a>
                                                        </div>
                                                        <!-- End .product-action -->

                                                        <div class="product-action action-icon-top">
                                                            <a href="inner.aspx?id=<%# Eval("product_id") %>" class="btn-product btn-cart"><span>VIEW MORE</span></a>

                                                        </div>
                                                        <!-- End .product-action -->
                                                    </figure>
                                                    <!-- End .product-media -->

                                                        <div class="product-body">
                                                        <div class="product-cat">
                                                            <a href="#"><%# Eval("sport_name") %></a>
                                                        </div>
                                                        <!-- End .product-cat -->
                                                        <h3 class="product-title"><a href="inner.aspx?id=<%# Eval("product_id") %>"><%# Eval("p_name") %></a></h3>
                                                        <!-- End .product-title -->
                                                        <div class="product-price">
                                                            
                                                                ₹<%# Eval("price") %>
                                                        </div>
                                                        <!-- End .product-price -->
                                                        
                                                        <!-- End .rating-container -->
                                                         </div>
														  

                                                        <!-- End .product-nav -->
                                                    </div>
                                                    <!-- End .product-body -->
                                                </div>
                                                <!-- End .product -->
												</ItemTemplate> <FooterTemplate>
                                            </div>
                                            <!-- End .col-sm-6 col-lg-4 col-xl-3 -->


                                             
						  </div></FooterTemplate>
                                         
                                        
                                
                                                      </asp:Repeater>
                          
                            </div>
                       
                    </div>
                 </main>
                </div>
           

       
        <button id="scroll-top" title="Back to Top"><i class="icon-arrow-up"></i></button>
    
         
   <!-- End .page-content -->
        

        <!-- Mobile Menu -->

        <!-- Sign in / Register Modal -->

        <!-- Plugins JS File -->
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/js/bootstrap.bundle.min.js"></script>
        <script src="assets/js/jquery.hoverIntent.min.js"></script>
        <script src="assets/js/jquery.waypoints.min.js"></script>
        <script src="assets/js/superfish.min.js"></script>
        <script src="assets/js/owl.carousel.min.js"></script>
        <script src="assets/js/wNumb.js"></script>
        <script src="assets/js/bootstrap-input-spinner.js"></script>
        <script src="assets/js/jquery.magnific-popup.min.js"></script>
        <script src="assets/js/nouislider.min.js"></script>
        <!-- Main JS File -->
        <script src="assets/js/main.js"></script>
   

</asp:Content>
