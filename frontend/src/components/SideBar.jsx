
import styled  from "styled-components"
import SideBarToggler from "./SideBarToggler";
import PropTypes from "prop-types";
import SideBarItem from "./SideBarItem";
import { IoHome } from "react-icons/io5";

const StyledSideBar=styled.nav`
    display: ${({showSidebar})=>showSidebar?"flex":"none"};
    flex-direction: column;
    height: 100vh;
    position: fixed;
    padding:0px 10px;
    top: 0;
    left: 0;
    width: 200px;
    background-color:${({theme})=>theme.componentBackground};
    z-index: 100;
  `;

function SideBar({showSidebar,tooglevisible,routes}) {
    
    return (
        <StyledSideBar showSidebar={showSidebar}>
            <SideBarToggler tooglevisible={tooglevisible}/>
            {
                routes.map((route,index)=><SideBarItem key={index} to={route.to} text={route.text} icon={route.icon}/>)
            }
        </StyledSideBar>
    )
}

SideBar.propTypes = {
    showSidebar:PropTypes.bool,
    tooglevisible:PropTypes.func

}
export default SideBar