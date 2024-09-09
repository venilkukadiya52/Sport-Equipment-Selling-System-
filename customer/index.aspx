 <%@ Page Title="" Language="C#" MasterPageFile="~/customer/header.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" CodeFile="index.aspx.cs"  Inherits="Sport.customer.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<main class="main">
            <div class="intro-slider-container mb-5">
                <div class="intro-slider owl-carousel owl-theme owl-nav-inside owl-light" data-toggle="owl" 
                    data-owl-options='{
                        "dots": true,
                        "nav": false, 
                        "responsive": {
                            "1200": {
                                "nav": false,
                                "dots": false
                            }
                        }
                    }'>
                    <div class="intro-slide" style="background-image: url(assets/images/demos/demo-21/slider/slide-1.png);">
                        <div class="container intro-content">
                            <div class="row">
                                <div class="intro">
                                    <div class="title">
                                        <h3>SPORT'S</h3>
                                    </div>
                                    <div class="content">
                                        <h3>EQUIPMENTS </h3>
                                        <h3>Fast and Furious.</h3>
                                    </div>
                                    <div class="price">
                                        <h3>SAVE UP TO 30%</h3>
                                        </div>
                                    <div class="action">
                                        <a href="product.aspx" class="btn btn-primary">
                                            <span>DISCOVER NOW</span>
                                        </a>
                                    </div>

                                </div>
                            </div><!-- End .row -->
                        </div><!-- End .intro-content -->
                    </div><!-- End .intro-slide -->

                    <div class="intro-slide" style="background-image: url(assets/images/demos/demo-21/slider/slide-2.jpg);">
                        <div class="container intro-content">
                            <div class="row">
                                <div class="intro">
                                    <div class="title">
                                        <h3 class="darkWhite">DEAL OF THE DAY</h3>
                                    </div>
                                    <div class="content">
                                        <h3>IT'S TIME TO UPGRADE<br>YOUR HIKING KIT</h3>
                                    </div>
                                    <div class="price">
                                        <h3 class="darkWhite">SAVE UP TO 15%</h3>
                                    </div>
                                    <div class="action">
                                        <a href="prod.aspx" class="btn btn-primary">
                                            <span>DISCOVER NOW</span>
                                        </a>
                                    </div>
                                </div>
                            </div><!-- End .row -->
                        </div><!-- End .intro-content -->
                    </div><!-- End .intro-slide -->


                    
                </div><!-- End .intro-slider owl-carousel owl-simple -->

                <span class="slider-loader"></span><!-- End .slider-loader -->
            </div><!-- End .intro-slider-container -->

            <!-----3 box after slider bar -------->
            <div class="container banner-container">
                <div class="col-lg-4 col-md-8 col-sm-10 col-12 col-pd1">
                    <a href="product.aspx">
                        <img src="assets/images/demos/demo-21/banner/banner-1.jpg">
                    </a>
                    <div class="banner-content">
                        <div class="title">
                            <a href="prod.aspx"><h3 class="darkWhite">It's a lifestyle.</h3></a>
                        </div>
                        <div class="content">
                            <a href="prod.aspx"><h3>Running Apparel</h3></a>
                            <a href="prod.aspx"><h3>END OF SEASON SALE</h3></a>
                        </div>
                        <div class="action">
                            <a href="prod.aspx" class="btn btn-demoprimary">
                                <span>SHOP NOW</span>
                                <i class="icon-long-arrow-right"></i>
                            </a>
                        </div>
                    </div><!-- End .row -->
                </div>
                <div class="col-lg-4 col-md-8 col-sm-10 col-12 col-pd1">
                    <a href="prod.aspx">
                        <img src="assets/images/demos/demo-21/banner/banner-2.jpg">
                    </a>
                    <div class="banner-content">
                        <div class="title">
                            <a href="prod.aspx"><h3 class="darkWhite">Hike Your Next Trail </h3></a>
                        </div>
                        <div class="content">
                            <a href="prod.aspx"><h3>NEW SEASON</h3></a>
                            <a href="prod.aspx"><h3>NEW GEAR</h3></a>
                        </div>
                        <div class="action">
                            <a href="prod.aspx" class="btn btn-demoprimary">
                                <span>DISCOVER NOW</span>
                                <i class="icon-long-arrow-right"></i>
                            </a>
                        </div>
                    </div><!-- End .row -->
                </div>
                <div class="col-lg-4 col-md-8 col-sm-10 col-12 col-pd1">
                    <a href="prod.aspx">
                        <img src="assets/images/demos/demo-21/banner/banner-3.jpg">
                    </a>
                    <div class="banner-content">
                        <div class="title">
                            <a href="prod.aspx"><h3 class="darkWhite">Summer Sale</h3></a>
                        </div>
                        <div class="content">
                            <a href="prod.aspx"><h3>Swimwear sale</h3></a>                            <a href=""><h3>Swimwear sale</h3></a>
                            <a href="prod.aspx"><h3>Save up to 30%</h3></a>
                        </div>
                        <div class="action">
                            <a href="prod.aspx" class="btn btn-demoprimary">
                                <span>SHOP NOW</span>
                                <i class="icon-long-arrow-right"></i>
                            </a>
                        </div>
                    </div><!-- End .row -->
                </div>
            </div>


            <div class="container logos">
                <div class="owl-carousel mb-5 owl-simple" data-toggle="owl" 
                    data-owl-options='{
                        "nav": true, 
                        "dots": false,
                        "margin": 10,
                        "loop": false,
                        "responsive": {
                            "0": {
                                "items":2
                            },
                            "420": {
                                "items":3
                            },
                            "600": {
                                "items":4
                            },
                            "900": {
                                "items":5<a href="index.aspx">index.aspx</a>
                            },
                            "1024": {
                                "items":6
                            }
                        }
                    }'>
                    <a href="#" class="brand">
                        <img src="assets/images/brands/1.png" alt="Brand Name">
                    </a>

                    <a href="#" class="brand">
                        <img src="assets/images/brands/2.png" alt="Brand Name">
                    </a>

                    <a href="#" class="brand">
                        <img src="assets/images/brands/3.png" alt="Brand Name">
                    </a>

                    <a href="#" class="brand">
                        <img src="assets/images/brands/4.png" alt="Brand Name">
                    </a>

                    <a href="#" class="brand">
                        <img src="assets/images/brands/5.png" alt="Brand Name">
                    </a>

                    <a href="#" class="brand">
                        <img src="assets/images/brands/6.png" alt="Brand Name">
                    </a>

                    <a href="#" class="brand">
                        <img src="assets/images/brands/7.png" alt="Brand Name">
                    </a>
                </div><!-- End .owl-carousel -->
            </div><!-- End .container -->

            <div class="container bestsellers">
                <hr class="mb-3">
                <div class="heading">
                    <h2 class="title text-center">BEST SELLERS</h2>
                    <p class="content text-center mb-4">The Trends Boutique: The latest fashion trends from top brands!</p>
                </div>

                <div class="owl-carousel owl-simple carousel-equal-height carousel-with-shadow" data-toggle="owl" 
                    data-owl-options='{
                        "nav": true, 
                        "dots": false,
                        "margin": 20,
                        "loop": false,
                        "responsive": {
                            "0": {
                                "items":2
                            },
                            "768": {
                                "items":3
                            },
                            "992": {
                                "items":4
                            }
                        }
                    }'>

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                    <div class="product demo21">
                        <figure class="product-media">
                            <span class="product-label label-sale">Sale</span>
                            <a href="prod.aspx">
                                <img src='<%# Eval("image1") %>' alt="Product image" class="product-image">
                                <img src='<%# Eval("image2") %>' alt="Product image" class="product-image-hover">
                            </a>

                        </figure><!-- End .product-media -->

                        <div class="product-body text-center">
                            <div class="product-cat">
                                <a href="#"><%# Eval("sport_name") %></a>
                            </div><!-- End .product-cat -->
                            <h3 class="product-title"><a href="prod.aspx"><%# Eval("p_name") %></a></h3><!-- End .product-title -->
                            <div class="product-price">
                                <span class="new-price"><%# Eval("price") %></span>
                               
                            </div><!-- End .product-price -->
                          

                            <div class="product-action">
                                <a href="inner.aspx?id=<%# Eval("product_id") %>" class="btn-product btn-cart" title="Add to cart"><span>ADD TO CART</span></a>
                                <a href="#" class="btn-addtolist"><span>&nbsp;Add to Wishlist</span></a>
                            </div><!-- End .product-action -->


                        </div><!-- End .product-body -->
                    </div>
                            </ItemTemplate>
</asp:Repeater>
                    <!-- End .product -->

                   

                    
                        

                </div><!-- End .owl-carousel -->
            </div>
            
            <!---------choose youe style over here-->
         
            <!----------4 diffrent category over-->

            <%--<div class="container newsletter">
                <div class="background" style="background-image: url(assets/images/demos/demo-21/newsLetter/banner.jpg);">
                    <div class="subscribe">
                        <div class="subscribe-title text-center">
                            <h1 class="intro-title2nd">ENTER YOUR EMAIL</h1>
                            <h1 class="intro-title1st">Get to know about new offers and get more deals by joining our us</h1>
                        </div>
                        <form action="#">
                            <div class="input-group">
                                <input type="email" placeholder="Enter your Email Address" aria-label="Email Adress" required="">
                                <div class="input-group-append">
                                    <button class="btn btn-subscribe" type="submit"><span>REGISTER</span><i class="icon-long-arrow-right"></i></button>
                                </div><!-- .End .input-group-append -->
                            </div><!-- .End .input-group -->
                        </form>
                    </div>  
                </div>
            </div>--%>

            <div class="container service mt-4">
                <div class="col-sm-6 col-lg-3 col-noPadding">
                    <div class="icon-box icon-box-side">
                        <span class="icon-box-icon text-dark">
                            <i class="icon-truck"></i>
                        </span>

                        <div class="icon-box-content">
                            <h3 class="icon-box-title">Payment &amp; Delivery</h3><!-- End .icon-box-title -->
                            <p>Free shipping for orders over $50</p>
                        </div><!-- End .icon-box-content -->
                    </div><!-- End .icon-box -->
                </div><!-- End .col-sm-6 col-lg-4 -->
                
                <div class="col-sm-6 col-lg-3">
                    <div class="icon-box icon-box-side">
                        <span class="icon-box-icon text-dark">
                            <i class="icon-rotate-left"></i>
                        </span>

                        <div class="icon-box-content">
                            <h3 class="icon-box-title">Return &amp; Refund</h3><!-- End .icon-box-title -->
                            <p>Free 100% money back guarantee</p>
                        </div><!-- End .icon-box-content -->
                    </div><!-- End .icon-box -->
                </div><!-- End .col-sm-6 col-lg-4 -->

                <div class="col-sm-6 col-lg-3">
                    <div class="icon-box icon-box-side">
                        <span class="icon-box-icon text-dark">
                            <i class="icon-life-ring"></i>
                        </span>

                        <div class="icon-box-content">
                            <h3 class="icon-box-title">Quality Support</h3><!-- End .icon-box-title -->
                            <p>Alway online feedback 24/7</p>
                        </div><!-- End .icon-box-content -->
                    </div><!-- End .icon-box -->
                </div><!-- End .col-sm-6 col-lg-4 -->

                <div class="col-sm-6 col-lg-3">
                    <div class="icon-box icon-box-side">
                        <span class="icon-box-icon text-dark">
                            <i class="icon-envelope"></i>
                        </span>

                        <div class="icon-box-content">
                            <h3 class="icon-box-title">JOIN OUR NEWSLETTER</h3><!-- End .icon-box-title -->
                            <p>10% off by subscribing to our newsletter</p>
                        </div><!-- End .icon-box-content -->
                    </div><!-- End .icon-box -->
                </div><!-- End .col-sm-6 col-lg-4 -->
            </div>

            
        </main>

</asp:Content>