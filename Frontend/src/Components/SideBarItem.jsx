import styled from "styled-components";
import  useTheme  from "../Context/useTheme";
import { NavLink } from "react-router-dom";

const StyledLink = styled(NavLink)`
    text-decoration: none;
    color: ${({theme}) => theme.lightgraynav};
    font-size: 24px;
    display:flex;
    align-items: flex-start;
    padding: 10px 16px;

    &.active{
        color: ${({theme}) => theme.white};
    }
`
const Icon= styled.div`
    font-size: 24px;
    margin-right: 16px;
    display:flex;
    justify-content: center;
    align-items: center;
`
const Text= styled.div`
    font-size: 24px;
    margin-right: 16px;
    vertical-align: bottom;
`


function SideBarItem({to,icon,text}) {
    const {theme} = useTheme();
    return (
        <StyledLink to={to} theme={theme}><Icon>{icon}</Icon><Text>{text}</Text></StyledLink>
    )
}

export default SideBarItem;