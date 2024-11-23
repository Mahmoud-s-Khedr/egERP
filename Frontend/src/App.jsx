import './App.css'
import {  createBrowserRouter, RouterProvider } from 'react-router-dom'
import AppLayOut from './LayOuts/AppLayOut'
import DashBoard from './Pages/DashBoard';
import Customers from './Pages/Customers';
import CustomerProfile from './Pages/CustomerProfile';
function App() {
  const router = createBrowserRouter([
    {
      path:"/",
      element:<AppLayOut/>,
      children:[
        {
          path:"",
          element:<div>home</div>
        },
        {
          path:"login",
          element: <div>log in </div>
        },
        {
          path:"myaccount",
          element:<div>myaccount</div>
        },
        {
          path:"dashboard",
          element:<DashBoard/>
        },
        {
          path:"employees",
          element:<div>employees</div>
        },
        {
          path:"employees/:id",
          element:<div>employee by id</div>,
          
        },
        {
          path:"customers",
          element:<Customers/>
        },
        {
          path:"customers/:id",
          element:<CustomerProfile/> 
        },
        {
          path:"products",
          element:<div>products</div>
        },
        {
          path:"products/:id",
          element:<div>products by id</div>,
          
        },
        {
          path:"orders",
          element:<div>orders</div>
        },
        {
          path:"orders/:id",
          element:<div>orders by id</div>,
        },
        {
          path:"suppliers",
          element:<div>suppliers</div>
        },
        {
          path:"suppliers/:id",
          element:<div>suppliers by id</div>,
        }
      ]
    },
  ],
    {
      future: {
        v7_startTransition: true,
        v7_relativeSplatPath: true,
        v7_fetcherPersist: true,
        v7_normalizeFormMethod: true,
        v7_partialHydration: true,
        v7_skipActionErrorRevalidation: true
      }
    }
  );

  return (
    <>
      <RouterProvider router={router}/>
    </>
  )
}

export default App
