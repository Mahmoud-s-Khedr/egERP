import styled from "styled-components"
import useTheme from "../Context/useTheme"
import { NavLink } from "react-router-dom"
import { IoLogOutOutline, IoPersonOutline, IoSettingsOutline } from "react-icons/io5"

const DropDownContainer = styled.nav`
    display:flex;
    flex-direction: column;
    gap: 24px;
    padding: 16px 16px;
    background-color: ${({theme}) => theme.ComponentBackground};
    border-radius: 8px;
    position: absolute;
    top: 90px;
    right: 24px;
    z-index: 1;
`
const DropDownItem = styled(NavLink)`
    font-size: 16px;
    color: ${({theme}) => theme.darkgray};
    display:flex;
    align-items: center;
    text-decoration: none;
    gap: 24px;
    cursor: pointer;
    &:hover{
        background-color: ${({theme}) => theme.primary}20;
        color: ${({theme}) => theme.primary};
    }
`
const Icon = styled.div`
    font-size: 24px;
`
function DropDown({open}) {
    const {theme} = useTheme();
    return (
        open &&
        <DropDownContainer theme={theme}>
            <DropDownItem theme={theme} to="/profile"><Icon><IoPersonOutline/></Icon>Profile</DropDownItem>
            <DropDownItem theme={theme} to="/settings"><Icon><IoSettingsOutline/></Icon>Settings</DropDownItem>
            <DropDownItem theme={theme} to="/logout"><Icon><IoLogOutOutline/></Icon>Logout</DropDownItem>
        </DropDownContainer>
    )
}

export default DropDown