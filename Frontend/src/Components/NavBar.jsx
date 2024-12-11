import styled from "styled-components";
import useTheme from "../Context/useTheme";
import { IoReorderThreeOutline, IoSunnyOutline } from "react-icons/io5";
import { FaAngleDown } from "react-icons/fa";
import { GoMoon } from "react-icons/go";
import { useState } from "react";
import DropDown from "./DropDown";

const NavBarContainer = styled.div`
    height: 60px;
    background-color:${({theme}) => theme.ComponentBackground};
    display:flex;
    color: ${({theme}) => theme.text};
    padding: 10px 24px;
`
const Icon = styled.div`
    font-size: 60px;
`
const RightContainer = styled.div`
    display:flex;
    justify-content: flex-end;
    align-items: center;
    flex-grow: 1;
`
const ProfileImage = styled.img`
    width: 60px;
    height: 60px;
    border-radius: 50%;
    margin-right: 10px;
`
const RightContainerIcon = styled.div`
    font-size: 30px;
    margin-right: 24px;
`
function NavBar({setSideBarOpen,sideBarOpen}) {
    const {theme, isDarkMode, toggleTheme} = useTheme();
    const [dropDownOpen, setDropDownOpen] = useState(false);

    return (
        <NavBarContainer theme={theme}>
            <Icon onClick={()=>setSideBarOpen(!sideBarOpen)}><IoReorderThreeOutline/></Icon>
            <RightContainer>
                <RightContainerIcon onClick={toggleTheme} style={{cursor: 'pointer'}}>
                    {isDarkMode ? <IoSunnyOutline/>:<GoMoon/>}
                </RightContainerIcon>
                <ProfileImage src="https://images.unsplash.com/photo-1499714608240-22fc6ad53fb2?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80" alt="profile" />
                <FaAngleDown onClick={() => setDropDownOpen(!dropDownOpen)} />
            </RightContainer>
            <DropDown open={dropDownOpen}/>
        </NavBarContainer>
    )
}   

export default NavBar