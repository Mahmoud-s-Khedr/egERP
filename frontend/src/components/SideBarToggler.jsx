import styled  from "styled-components";
import PropTypes from "prop-types";
import { FaBars } from "react-icons/fa";
const StyledSideBarToggler=styled.button`
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 60px;
    font-size: ${({theme})=>theme.fontSize.xlarge};
    padding: 0 10px;
    color: ${({theme})=>theme.text};
    background-color:transparent;
    border:none;
    cursor: pointer;
    `;

function SideBarToggler({tooglevisible}) {
    return (
        <StyledSideBarToggler onClick={tooglevisible}>
            <FaBars/>
        </StyledSideBarToggler>
    )
}

SideBarToggler.propTypes = {
    tooglevisible:PropTypes.func
}

export default SideBarToggler;