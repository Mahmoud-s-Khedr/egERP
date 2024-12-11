import SideBar from "../Components/SideBar"
import Content from "../Components/Content"
import styled from "styled-components"
import { useState } from "react"
const Container = styled.div`
    display:flex;
`   


function AppLayout() {
    const [sideBarOpen, setSideBarOpen] = useState(true);

    return (
    <Container>
        {sideBarOpen && <SideBar/>}
        <Content setSideBarOpen={setSideBarOpen} sideBarOpen={sideBarOpen}/>
    </Container>
    )
}

export default AppLayout