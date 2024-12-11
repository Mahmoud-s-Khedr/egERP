import styled from "styled-components";
import  useTheme  from "../Context/useTheme";
import SideBarSection from "./SideBarSection";
import { BiHomeAlt } from "react-icons/bi";
import {  IoBagHandleOutline, IoPeopleOutline } from "react-icons/io5";
import { BsCart } from "react-icons/bs";
import { FaTasks } from "react-icons/fa";


const SideBarContainer = styled.nav`
    width:240px;
    height: 100vh;
    background-color:${({theme}) => theme.primary};
    display: flex;
    position: fixed;
    top: 0;
    left: 0;
    flex-direction: column;
    gap: 24px;
`
const SideBarHeader = styled.div`
    height: 80px;
    font-size: 36px;
    font-family:'jaro';
    color:white;
    display: flex;
    justify-content: center;
    align-items: center;
`


function SideBar() {
    const {theme} = useTheme();
    const sidebarsections =[
        {
            header:"Dashboard",
            items: [
                {
                    name:"Dashboard",
                    url:"/dashboard",
                    icon:<BiHomeAlt/>
                }
            ]
        },
        {
            header:"Crm",
            items: [
                {
                    name:"Customers",
                    url:"/customers",
                    icon:<IoPeopleOutline/>
                },
                {
                    name:"Products",
                    url:"/products",
                    icon:<IoBagHandleOutline/>
                },
                {
                    name:"Orders",
                    url:"/orders",
                    icon:<BsCart/>
                }
            ]
        },
        {
            header:"For you",
            items: [{
                name:"Tasks",
                url:"/tasks",
                icon:<FaTasks/>
            }]
        }
    ]
    return (
        <SideBarContainer theme={theme}>
            <SideBarHeader>EGERP</SideBarHeader>
            {sidebarsections.map((section,index) => <SideBarSection key={index} header={section.header} items={section.items}/>)}
        </SideBarContainer>
    )
}   

export default SideBar;