import { createBrowserRouter } from "react-router-dom"

import { RouterProvider } from "react-router-dom"
import AppLayout from "./Layouts/AppLayout"
import Theme from "./Context/ThemeProvider"
import DashBoard from "./Pages/DashBoard"
import Orders from "./Pages/Orders"
import Customers from "./Pages/Customers"
import Products from "./Pages/Products"
import Tasks from "./Pages/Tasks"
const router = createBrowserRouter([
  {
    path: "/",
    element: <AppLayout/>,
    children: [
          {
            path:"customers",
            element:<Customers/>
          },
          {
            path:"products",
            element:<Products/>
          },{
            path:"dashboard",
            element:<DashBoard/>
          },{
            path:"orders",
            element:<Orders/>
          },{
            path:"tasks",
            element:<Tasks/>
          },{
            path:"profile",
            element:<div>profile</div>
          },{
            path:"settings",
            element:<div>settings</div>
          },{
            path:"logout",
            element:<div>logout</div>
          }
    ]
  }

  
]
)

function App() {

  return (
      <Theme>
        <RouterProvider router={router}/>
      </Theme>
  )
}

export default App
