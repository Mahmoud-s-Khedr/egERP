import styled from "styled-components";
import { useState } from "react";
import SideBar from "../components/SideBar";
import NavBar from "../components/NavBar";
import { FaHome, FaShoppingCart, FaUsers } from "react-icons/fa";
import { IoBag, IoHome } from "react-icons/io5";
import { Outlet } from "react-router-dom";

const StyledLayOut=styled.div`
    display: flex;
    font-family: 'Poppins', sans-serif;
    box-sizing: border-box;
    flex-direction: column;
`;

const PageContent=styled.div`
    display: flex;
    flex-direction: column;
    min-height: calc(100vh - 60px);
    padding: 20px;
    margin-left: ${({sidebarvisible})=>sidebarvisible?"220px":"0px"};
    background-color: ${({theme})=>theme.background};
    color: ${({theme})=>theme.text};
    @media (max-width: 768px) {
      height: auto;
      width: 100%;
      margin-left: 0px;
      padding: 0px;
    }
`;
function AppLayOut() {
  const [sidebarvisible, setSidebarVisible] = useState(true);
  const crmsidebar=[
    {
      to:"/dashboard",
      text:"Dashboard",
      icon:<FaHome/>
    },{
      to:"/customer",
      text:"Customer",
      icon:<FaUsers/>
    },
    {
      to:"/product",
      text:"Product",
      icon:<IoBag/>
    },
    {
      to:"/order",
      text:"Order",
      icon:<FaShoppingCart/>
    }
  ]
  return (
    <div>
      <StyledLayOut>
        <SideBar showSidebar={sidebarvisible} tooglevisible={()=>setSidebarVisible(!sidebarvisible)} routes={crmsidebar}/>
        <NavBar sidebarvisible={sidebarvisible} togglesidebar={setSidebarVisible} />
        <PageContent sidebarvisible={sidebarvisible}>
          <Outlet/>
        </PageContent>
      </StyledLayOut>
    </div>
  )
}

export default AppLayOut;