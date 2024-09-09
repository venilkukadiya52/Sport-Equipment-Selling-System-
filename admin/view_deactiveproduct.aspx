<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_deactiveproduct.aspx.cs" CodeFile="view_deactiveproduct.aspx.cs" Inherits="Sport.admin.view_deactiveproduct" %>
<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8">
  <meta content="width=device-width, initial-scale=1.0" name="viewport">

  <title>Tables / Data - NiceAdmin Bootstrap Template</title>
  <meta content="" name="description">
  <meta content="" name="keywords">

  <!-- Favicons -->
  <link href="assets/img/favicon.png" rel="icon">
  <link href="assets/img/apple-touch-icon.png" rel="apple-touch-icon">

  <!-- Google Fonts -->
  <link href="https://fonts.gstatic.com" rel="preconnect">
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Nunito:300,300i,400,400i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">

  <!-- Vendor CSS Files -->
  <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <link href="assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
  <link href="assets/vendor/remixicon/remixicon.css" rel="stylesheet">
  <link href="assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
  <link href="assets/vendor/quill/quill.snow.css" rel="stylesheet">
  <link href="assets/vendor/quill/quill.bubble.css" rel="stylesheet">
  <link href="assets/vendor/simple-datatables/style.css" rel="stylesheet">

  <!-- Template Main CSS File -->
  <link href="assets/css/style.css" rel="stylesheet">

  <!-- =======================================================
  * Template Name: NiceAdmin - v2.1.0
  * Template URL: https://bootstrapmade.com/nice-admin-bootstrap-admin-html-template/
  * Author: BootstrapMade.com
  * License: https://bootstrapmade.com/license/
  ======================================================== -->
</head>

<body>
      <header id="header" class="header fixed-top d-flex align-items-center">

    <div class="d-flex align-items-center justify-content-between">
      <a href="admin-index.aspx" class="logo d-flex align-items-center">
        <img src="assets/img/logo.png" alt="">
        <span class="d-none d-lg-block">Admin</span>
      </a>
      <i class="bi bi-list toggle-sidebar-btn"></i>
    </div><!-- End Logo -->

   

    <nav class="header-nav ms-auto">
      
          <!-- End Messages Nav -->

        <li class="nav-item dropdown pe-3">

          <a class="nav-link nav-profile d-flex align-items-center pe-0" href="#" data-bs-toggle="dropdown">
            <img src="assets/img/profile-img.jpg" alt="Profile" class="rounded-circle">
            <span class="d-none d-md-block dropdown-toggle ps-2">ADMIN</span>
          </a><!-- End Profile Iamge Icon -->

          <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow profile">
            <li class="dropdown-header">
              <h6>ADMIN</h6>
              <span>MIT TRIVEDI</span>
            </li>
          
            <li>
              <hr class="dropdown-divider">
            </li>

           
            <li>
              <hr class="dropdown-divider">
            </li>
            <li>
              <a class="dropdown-item d-flex align-items-center" href="/customer/logout.aspx">
                <i class="bi bi-box-arrow-right"></i>
                <span>Sign Out</span>
              </a>
            </li>

          </ul><!-- End Profile Dropdown Items -->
        </li><!-- End Profile Nav -->

   
   
    </nav><!-- End Icons Navigation -->

  </header><!-- End Header -->
   
  <!-- ======= Sidebar ======= -->
  <aside id="sidebar" class="sidebar">

    <ul class="sidebar-nav" id="sidebar-nav">

      <li class="nav-item">
        <a class="nav-link " href="admin-index.aspx">
          <i class="bi bi-grid"></i>
          <span>Dashboard</span>
        </a>
      </li><!-- End Dashboard Nav -->
      <!-- End Components Nav -->

      <li class="nav-item">
        <a class="nav-link collapsed" data-bs-target="#forms-nav" data-bs-toggle="collapse" href="#">
          <i class="bi bi-journal-text"></i><span>PRODUCT</span><i class="bi bi-chevron-down ms-auto"></i>
        </a>
        <ul id="forms-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
          <li>
            <a href="admin-product.aspx">
              <i class="bi bi-circle"></i><span>ADD PRODUCT</span>
            </a>
          </li>
          <li>
            <a href="add_brand.aspx">
              <i class="bi bi-circle"></i><span>ADD BRAND</span>
            </a>
          </li>
         
        </ul>
      </li>
        
         <li class="nav-item">
        <a class="nav-link collapsed" data-bs-target="#forms-nav" data-bs-toggle="collapse" href="#">
          <i class="bi bi-journal-text"></i><span>STAFF</span><i class="bi bi-chevron-down ms-auto"></i>
        </a>
        <ul id="forms-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
          
          <li>
            <a href="Add_staff.aspx">
              <i class="bi bi-circle"></i><span>ADD STAFF</span>
            </a>
          </li>
          <li>
            <a href="view_staff.aspx">
              <i class="bi bi-circle"></i><span>VIEW STAFF</span>
            </a>
          </li>
        </ul>
      </li><!-- End Forms Nav -->

      <li class="nav-item">
        <a class="nav-link collapsed" data-bs-target="#tables-nav" data-bs-toggle="collapse" href="#">
          <i class="bi bi-layout-text-window-reverse"></i><span>PRODUCT</span><i class="bi bi-chevron-down ms-auto"></i>
        </a>
        <ul id="tables-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
          <li>
            <a href="view_product.aspx">
              <i class="bi bi-circle"></i><span>VIEW PRODUCT</span>
            </a>
          </li>
          <li>
            <a href="view_deactiveproduct.aspx">
              <i class="bi bi-circle"></i><span>DEACTIVE PRODUCT</span>
            </a>
          </li>
        </ul>
      </li><!-- End Tables Nav -->
    
    <!-- End Charts Nav -->
    <!-- End Icons Nav -->
<li class="nav-item">
        <a class="nav-link collapsed" data-bs-target="#tables-nav" data-bs-toggle="collapse" href="#">
          <i class="bi bi-layout-text-window-reverse"></i><span>REPORT</span><i class="bi bi-chevron-down ms-auto"></i>
        </a>
        <ul id="tables-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
          <li>
            <a href="view_customer.aspx">
              <i class="bi bi-circle"></i><span>VIEW CUSTOMER</span>
            </a>
          </li>
          <li>
            <a href="view_order.aspx">
              <i class="bi bi-circle"></i><span>VIEW ORDER</span>
            </a>
          </li>
        </ul>
      </li>
      <li class="nav-heading">Pages</li>

      <!-- End Profile Page Nav -->
    <!-- End F.A.Q Page Nav -->

      <!-- End Register Page Nav -->

      <li class="nav-item">
        <a class="nav-link collapsed" href="/customer/logout.aspx">
          <i class="bi bi-box-arrow-in-right"></i>
          <span>Logout</span>
        </a>
      </li><!-- End Login Page Nav -->

      <!-- End Error 404 Page Nav -->

     <!-- End Blank Page Nav -->

    </ul>

  </aside><!-- End Sidebar-->

  <!-- ======= Header ======= -->
  <!-- End Sidebar-->

  
  <main id="main" class="main">

    <div class="pagetitle">
      <h1>Dashboard</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="index.html">Home</a></li>
          <li class="breadcrumb-item active">Dashboard</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class="section dashboard">
      <div class="row">

        <!-- Left side columns -->
        <div class="col-lg-8">
          <div class="row">

            <!-- Sales Card -->
           <!-- End Sales Card -->

            <!-- Revenue Card -->
            <!-- End Revenue Card -->

            <!-- Customers Card -->
     <!-- End Customers Card -->

            <!-- Reports -->
            <!-- End Reports -->

            <!-- Recent Sales -->
            <!-- End Recent Sales -->

            <!-- Top Selling -->
            <div class="col-12">
              <div class="card top-selling">

                <div class="filter">
                  <a class="icon" href="#" data-bs-toggle="dropdown"><i class="bi bi-three-dots"></i></a>
                  <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow">
                    <li class="dropdown-header text-start">
                      <h6>Filter</h6>
                    </li>

                    <li><a class="dropdown-item" href="#">Today</a></li>
                    <li><a class="dropdown-item" href="#">This Month</a></li>
                    <li><a class="dropdown-item" href="#">This Year</a></li>
                  </ul>
                </div>

                <div class="card-body pb-0">
                  <h5 class="card-title">PRODUCT <span>| Today</span></h5>
                    <form runat="server">
                  <table class="table table-borderless">
                    <thead>
                      <tr>
                        <th scope="col">Product Image</th>
                        <th scope="col">Product Name</th>
                        <th scope="col">Price</th>
                        <th scope="col">DEACTIVE</th>
                        
                       
                      </tr>
                    </thead>
                     
                          <asp:Repeater ID="rpt" runat="server">
                              <ItemTemplate>
                                  <tbody>

                                      <tr>
                                          <th scope="row"><a href="#">
                                              <img src='<%# Eval("image1") %>' alt=""></a></th>
                                          <td><a href="#" class="text-primary fw-bold"><%# Eval("p_name") %></a></td>
                                          <td><%# Eval("price") %></td>
                                          <td class="fw-bold">
                                              <asp:LinkButton runat="server" ID="active" CommandArgument='<%# Eval("product_id") %>' OnCommand="active_Command" Text="ACTIVE"></asp:LinkButton></td>            
<%--                                              <asp:LinkButton runat="server" ID="delete" CommandArgument='<%# Eval("product_id") %>' OnCommand="delete_Click" Text="DEACTIVE" ></asp:LinkButton></td>
                                          <td class="fw-bold"><asp:LinkButton runat="server" ID="update" CommandArgument='<%# Eval("product_id") %>' OnCommand="update_Click" Text="UPDATE" ></asp:LinkButton></td>
                                      --%></tr>

                                  </tbody>
                              </ItemTemplate>
                          </asp:Repeater>

                   
                  </table>
     </form>
                </div>

              </div>
            </div><!-- End Top Selling -->

          </div>
        </div><!-- End Left side columns -->

        <!-- Right side columns -->
        <div class="col-lg-4">

          <!-- Recent Activity -->
          <!-- End Recent Activity -->

          <!-- Budget Report -->
          <!-- End Budget Report -->

          <!-- Website Traffic -->
         <!-- End Website Traffic -->

          <!-- News & Updates Traffic -->
          <!-- End News & Updates -->

        </div><!-- End Right side columns -->

      </div>
    </section>

  </main><!-- End #main -->

  <!-- ======= Footer ======= -->
  <footer id="footer" class="footer">
    <div class="copyright">
      &copy; Copyright <strong><span>NiceAdmin</span></strong>. All Rights Reserved
    </div>
    <div class="credits">
      <!-- All the links in the footer should remain intact. -->
      <!-- You can delete the links only if you purchased the pro version. -->
      <!-- Licensing information: https://bootstrapmade.com/license/ -->
      <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/nice-admin-bootstrap-admin-html-template/ -->
      Designed by <a href="https://bootstrapmade.com/">BootstrapMade</a>
    </div>
  </footer><!-- End Footer -->

  <a href="#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

  <!-- Vendor JS Files -->
  <script src="assets/vendor/bootstrap/js/bootstrap.bundle.js"></script>
  <script src="assets/vendor/php-email-form/validate.js"></script>
  <script src="assets/vendor/quill/quill.min.js"></script>
  <script src="assets/vendor/tinymce/tinymce.min.js"></script>
  <script src="assets/vendor/simple-datatables/simple-datatables.js"></script>
  <script src="assets/vendor/chart.js/chart.min.js"></script>
  <script src="assets/vendor/apexcharts/apexcharts.min.js"></script>
  <script src="assets/vendor/echarts/echarts.min.js"></script>

  <!-- Template Main JS File -->
  <script src="assets/js/main.js"></script>

</body>

</html>
