import styled from "styled-components";
import { NavLink } from "react-router-dom";
const StyledSideBarItem=styled(NavLink)`
    display: flex;
    flex-direction: row;
    align-items: center;
    height: 60px;
    width: 100%;
    margin-top: 10px;
    text-decoration: none;
    color:${({theme})=>theme.text};
    font-size: ${({theme})=>theme.fontSize.large};
    font-weight: 500;
    border-radius: ${({theme})=>theme.borderRadius};
    cursor: pointer;
    &:hover{
        background-color: #ccc;
    }
    &.active{
        background-color: ${({theme})=>theme.primary};
        color:${({theme})=>theme.background};
    }
    `;
const SideBarIcon=styled.div`
    margin-right: 20px;
    margin-left: 20px;
    font-size: ${({theme})=>theme.fontSize.large};
    `;



function SideBarItem({to,text,icon}) {
    return (
        <StyledSideBarItem to={to}>
            <SideBarIcon>
            {icon}
            </SideBarIcon>
            {text}
        </StyledSideBarItem>
    )
}

export default SideBarItem