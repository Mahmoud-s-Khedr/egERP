import { createBrowserRouter, RouterProvider} from "react-router-dom";
import AppLayOut from "./layouts/AppLayOut";
import React from "react";
import { AppThemeProvider } from "./context/Theme";
import DashBoard from "./pages/DashBoard";
import Customers from "./pages/Customers";
function App() {
  const router = createBrowserRouter([
    {
      path: "/",
      element: <AppLayOut/>,
      children: [
        {
          path: "dashboard",
          element: <DashBoard/>
        },
        {
          path:"profile",
          element: <div>Profile</div>
        },
        {
          path:"login",
          element: <div>Login</div>
        },
        {
          path:"customer",
          element:<Customers/>
        },{
          path:"custemer/:id",
          element: <div>Customer id</div>
        },
        {
          path:"product",
          element: <div>Product</div> 
        },
        {
          path:"product/:id",
          element: <div>Product id</div>
        },
        {
          path:"employee",
          element: <div>Employee</div>
        },
        {
          path:"employee/:id",
          element: <div>Employee id</div>
        },
        {
          path:"order",
          element: <div>Order</div>
        }

      ]
    }
  ]);

  return (
    <AppThemeProvider>
      <RouterProvider router={router}/>
    </AppThemeProvider>
  );
}

export default App