
import styled from "styled-components";
import SideBarToggler from "./SideBarToggler";
import PropTypes from "prop-types";
import { useTheme } from "../context/Theme";
import React from "react";
import { IoSunnyOutline, IoMoonOutline } from "react-icons/io5";
import { FaAngleDown } from "react-icons/fa";
import DropdownMenu from "./DropDownMenu";
import { CiLogin } from "react-icons/ci";
import { useState } from "react";



const StyledNavBar=styled.nav`
        display: flex;
        flex-direction: row;
        box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
        border-bottom: 1px solid #8a8a8a;
        
        justify-content: ${({sidebarvisible})=>sidebarvisible?"flex-end":"space-between"};
        align-items: center;
        width: ${({sidebarvisible})=>sidebarvisible?"calc(100% - 200px)":"100%"};
        margin: ${({sidebarvisible})=>sidebarvisible?"0 0 0 200px":"0"};
        height: 60px;
        background-color: ${({theme})=>theme.background};
        @media (max-width: 768px) {
          width: 100%;
          margin: 0;
        }

        
    `;

const ImageContainer=styled.div`
        display: flex;
        flex-direction: row;
        align-items: center;
        height: 100%;
        margin-right: 10px;
`;
const Image=styled.img`
        height: 40px;
        width: 40px;
        border-radius: 50%;
        margin-right: 10px;
`;

const Button = styled.button`
        color: ${({ theme }) => theme.text};
        border: 0px;
        background-color: transparent;
        margin-right: 10px;
        margin-top: 5px;
        font-size:27px;
        width: 60px;
        display: flex;
        align-items: center;
        height: 100%;
        cursor: pointer;
`;


 function NavBar({sidebarvisible,togglesidebar}) {
  const {toggleTheme,isDarkMode}=useTheme();
  const [showDropdown, setShowDropdown] = useState(false);
  const dropdownOptions = [
    {
      label: "Profile",
      to:"/profile",
    }
    ,{
      label: "Settings",
      to:"/settings",
    },
    {
      label: "Logout",
      to:"/login",
      icon:<CiLogin/>
    }
  ];
    
  return (
    <StyledNavBar sidebarvisible={sidebarvisible}>
        {sidebarvisible || <SideBarToggler tooglevisible={()=>togglesidebar(!sidebarvisible)} />}
        <Button onClick={toggleTheme}>
          {isDarkMode?<IoMoonOutline/>:<IoSunnyOutline/>}
        </Button>
        <ImageContainer>
          <Image src="https://cdn-icons-png.flaticon.com/512/149/149071.png" alt="profile"/>
        </ImageContainer>
        <Button onClick={() => setShowDropdown(!showDropdown)}>
          <FaAngleDown/>
        </Button>
        <DropdownMenu showDropdown={showDropdown}  options={dropdownOptions}/>
        
    </StyledNavBar>
  )
}

NavBar.propTypes = {
    sidebarvisible:PropTypes.bool,
    togglesidebar:PropTypes.func
}

export default NavBar; 