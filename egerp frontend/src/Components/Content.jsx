import { Outlet } from "react-router-dom";
import styled from "styled-components";
import useTheme from "../Context/useTheme";
import NavBar from "./NavBar";

const ContentContainer= styled.div`
    width: 100%;
    margin-left: ${({sideBarOpen}) => sideBarOpen ? '240px' : '0px'};
    min-height: 100vh;
    background-color: ${({theme}) => theme.background};
    
`

const PageContainer = styled.div`
    padding: 24px;
`


function Content({setSideBarOpen,sideBarOpen}) {
    const {theme} = useTheme();

    return (
        <ContentContainer theme={theme} sideBarOpen={sideBarOpen}>
            <NavBar setSideBarOpen={setSideBarOpen} sideBarOpen={sideBarOpen}/>
            <PageContainer>
                <Outlet/>
            </PageContainer>
        </ContentContainer>)
}


export default Content;
