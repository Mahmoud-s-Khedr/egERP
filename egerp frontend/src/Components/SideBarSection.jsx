import styled from "styled-components";
import useTheme from "../Context/useTheme";
import SideBaritem from "./SideBarItem";

const SidebarSectionContainer = styled.div`
    display:flex;
    flex-direction: column;
    gap: 6px;
    padding: 16px;
`

const SidebarSectionHeader = styled.div`
    font-size: 16px;
    font-weight: 600;
    color: ${({theme}) => theme.lightgraynav};
`

function SideBarSection({header,items}) {
    const {theme} = useTheme();


    return (
        <SidebarSectionContainer >
            <SidebarSectionHeader  theme={theme}>{header}</SidebarSectionHeader>
            {items.map((item,index) => <SideBaritem key={index} icon={item.icon} text={item.name} to={item.url}/>)}
        </SidebarSectionContainer>
    )
}   

export default SideBarSection