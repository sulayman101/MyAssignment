<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyAssignment.pages.Login" %>
<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Purple Admin</title>
    <!-- plugins:css -->
    <link rel="stylesheet" href="../../assets/vendors/mdi/css/materialdesignicons.min.css">
    <link rel="stylesheet" href="../../assets/vendors/css/vendor.bundle.base.css">
    <!-- endinject -->
    <!-- Plugin css for this page -->
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <!-- endinject -->
    <!-- Layout styles -->
    <link rel="stylesheet" href="../../assets/css/style.css">
    <!-- End layout styles -->
    <link rel="shortcut icon" href="../../assets/images/favicon.ico" />
  </head>
  <body>
      <form runat="server" id="form">
    <div class="container-scroller">
      <div class="container-fluid page-body-wrapper full-page-wrapper">
        <div class="content-wrapper d-flex align-items-center auth">
          <div class="row flex-grow">
            <div class="col-lg-4 mx-auto">
              <div class="auth-form-light text-left p-5">
                <div class="brand-logo">
                  <img src="../../assets/images/logo.svg">
                </div>
                <h4>Hello! let's get started</h4>
                <h6 class="font-weight-light">Sign in to continue.</h6>
                <form class="pt-3">
                  <div class="form-group">
                      <asp:TextBox ID="txtUser" runat="server" CssClass="form-control form-control-lg" placeholder="Username ex: Admin" required="true"></asp:TextBox>
                      <%--<input type="email" class="form-control form-control-lg" id="exampleInputEmail1" placeholder="Username">--%>
                  </div>
                  <div class="form-group">
                      <%--<input type="password" class="form-control form-control-lg" id="exampleInputPassword1" placeholder="Password">--%>
                      <asp:TextBox ID="txtPass"  runat="server" TextMode="password" CssClass="form-control form-control-lg" placeholder="Password ex: 1234" required="true"></asp:TextBox>
                  </div>
                  <div class="mt-3">
                      <%--<a class="btn btn-block btn-gradient-primary btn-lg font-weight-medium auth-form-btn" href="../../index.html">SIGN IN</a>--%>
                      <asp:Button CssClass="btn btn-block btn-gradient-primary btn-lg font-weight-medium auth-form-btn" ID="btnSingIn" runat="server" Text="SIGN IN" OnClick="btnSingIn_Click"/>
                  </div>
                  <div class="my-2 d-flex justify-content-between align-items-center">
                      <asp:LinkButton CssClass="auth-link text-black" ID="btnFGT" runat="server" Text="Forgot password?" />
                      <%--<a href="#" class="auth-link text-black">Forgot password?</a>--%>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
        <!-- content-wrapper ends -->
      </div>
      <!-- page-body-wrapper ends -->
    </div>
          </form>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src="../../assets/vendors/js/vendor.bundle.base.js">