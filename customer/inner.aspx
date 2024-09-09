<%@ Page Title="" Language="C#" MasterPageFile="~/customer/header.Master" AutoEventWireup="true" CodeBehind="inner.aspx.cs" CodeFile="inner.aspx.cs" Inherits="Sport.customer.inner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-wrapper">

        <main class="main">
            <nav aria-label="breadcrumb" class="breadcrumb-nav border-0 mb-0">
                <div class="container d-flex align-items-center">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="index.aspx">Home</a></li>
                        <li class="breadcrumb-item"><a href="prod.aspx">Products</a></li>
                       
                    </ol>

                    <nav class="product-pager ml-auto" aria-label="Product">
                        
                    </nav>
                    <!-- End .pager-nav -->
                </div>
                <!-- End .container -->
            </nav>
            <!-- End .breadcrumb-nav -->
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="page-content">
                        <div class="container">
                            <div class="product-details-top">
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="product-gallery product-gallery-vertical">
                                            <div class="row">
                                                <figure class="product-main-image">
                                                    <img id="product-zoom" src="<%# Eval("image1") %>" data-zoom-image="<%# Eval("image1") %>" alt="product image">

                                                    <a href="#" id="btn-product-gallery" class="btn-product-gallery">
                                                        <i class="icon-arrows"></i>
                                                    </a>
                                                </figure>
                                                <!-- End .product-main-image -->

                                                <div id="product-zoom-gallery" class="product-image-gallery">
                                                    <a class="product-gallery-item active" href="#" data-image="<%# Eval("image1") %>" data-zoom-image="<%# Eval("image1") %>">
                                                        <img src="<%# Eval("image1") %>" alt="product side">
                                                    </a>

                                                    <a class="product-gallery-item" href="#" data-image="<%# Eval("image2") %>" data-zoom-image="<%# Eval("image2") %>">
                                                        <img src="<%# Eval("image2") %>" alt="product cross">
                                                    </a>

                                                    <a class="product-gallery-item" href="#" data-image="<%# Eval("image3") %>" data-zoom-image="<%# Eval("image3") %>">
                                                        <img src="<%# Eval("image3") %>" alt="product with model">
                                                    </a>

                                                    <a class="product-gallery-item" href="#" data-image="<%# Eval("image4") %>" data-zoom-image="<%# Eval("image4") %>">
                                                        <img src="<%# Eval("image4") %>" alt="product back">
                                                    </a>
                                                </div>
                                                <!-- End .product-image-gallery -->
                                            </div>
                                            <!-- End .row -->
                                        </div>
                                        <!-- End .product-gallery -->
                                    </div>
                                    <!-- End .col-md-6 -->

                                    <div class="col-md-6">
                                        <div class="product-details">
                                            <h1 class="product-title"><%# Eval("p_name") %></h1>
                                            <!-- End .product-title -->

                                            <!-- End .rating-container -->

                                            <div class="product-price">
                                                ₹ <%# Eval("price") %>
                                            </div>
                                            <!-- End .product-price -->
                                            
                                            <div class="product-content">
                                                <label>TYPE OF SPORT:</label>
                                                <%# Eval("sport_name") %>
                                            </div>
                                            <!-- End .product-content -->
                                            <div class="product-content">
                                                <label>SIZE:</label>
                                                <%# Eval("size") %>
                                            </div>
                                            <div class="product-content">
                                                <label>MATERIAL:</label>
                                                <%# Eval("material") %>
                                            </div>
                                            <div class="product-content">
                                                <label>AGE RANGE:</label>
                                                <%# Eval("age_range") %>
                                            </div>

                                            


                                            <div class="details-filter-row details-row-size">

                                                <!-- End .product-details-quantity -->
                                            </div>
                                            <!-- End .details-filter-row -->

                                            <!-- End .product-details-action -->

                                            <!-- End .product-details-footer -->
                                        </div>
                                        <!-- End .product-details -->
                                    </div>
                                    <!-- End .col-md-6 -->
                                </div>
                                <!-- End .row -->
                            </div>
                            <!-- End .product-details-top -->



                            <!-- End .owl-carousel -->
                        </div>
                        <!-- End .container -->
                    </div>
                </ItemTemplate>
            </asp:Repeater>
              <center>
            <div class="product-details-quantity">
                                                <label for="qty">Qty:</label>
                                                <asp:TextBox ID="qty" min="1" Text="1" class="form-control" TextMode="Number" runat="server"></asp:TextBox>
                                            </div>
          
                <!-- End .page-content -->

                <div class="product-details-action">
                    <div class="form-footer">
                        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:LinkButton ID="add" class="btn btn-outline-primary-2" runat="server" OnClick="add_Click">
			                					<span>ADD TO CART</span>
			            						<%--<i class="icon-long-arrow-right"></i>--%>
                    </asp:LinkButton>
                        &nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:LinkButton ID="wishlist" class="btn btn-outline-primary-2" runat="server" OnClick="wishlist_Click">
			                					<span>ADD TO WISHLIST</span>
			            						<%--<i class="icon-long-arrow-right"></i>--%>
                    </asp:LinkButton>
                    </div>
                    </div>
            </center>
        </main>
        <!-- End .main -->
        <!-- End .footer -->
    </div>
    <!-- End .page-wrapper -->
    <button id="scroll-top" title="Back to Top"><i class="icon-arrow-up"></i></button>

    <!-- Sticky Bar -->
    <!-- End .sticky-bar -->

    <!-- Mobile Menu -->
    <div class="mobile-menu-overlay"></div>
    <!-- End .mobil-menu-overlay -->

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
    <script src="assets/js/bootstrap-input-spinner.js"></script>
    <script src="assets/js/jquery.elevateZoom.min.js"></script>
    <script src="assets/js/bootstrap-input-spinner.js"></script>
    <script src="assets/js/jquery.magnific-popup.min.js"></script>
    <!-- Main JS File -->
    <script src="assets/js/main.js"></script>

</asp:Content>
