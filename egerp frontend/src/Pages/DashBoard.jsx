import styled from "styled-components";
import DashBoardCard from "../Components/DashBoardCard";
import { BsCart } from "react-icons/bs";
import { IoCashOutline, IoPeopleOutline } from "react-icons/io5";
import useTheme from "../Context/useTheme";
import BarCharts from "../Components/BarCharts";
import PieCharts from "../Components/PieCharts";
import Table from "../Components/Table";
import { Pie } from "recharts";
const CardsContainer = styled.div`
    display:flex;
    flex-direction: row;
    gap: 24px;
`


function DashBoard() {
    const {theme} = useTheme();
    console.log(theme);
    return (
        <>
            <CardsContainer>
                <DashBoardCard header="Orders" icon={<BsCart/>} body={10} footer="Total Orders : 100" f
                ootervalue="+10%" color={theme.primary}/>
                <DashBoardCard header="Customers" icon={<IoPeopleOutline/>} 
                body={12} footer="Total Cutomers: 90" footervalue="+15%" color={theme.secondary}/>
                <DashBoardCard header="Sales" icon={<IoCashOutline/>} 
                body={5000} footer="Total income : 10000" footervalue="+20%" color={theme.yellow}/>
            </CardsContainer>
            <CardsContainer style={{marginTop:"24px"}}>
                <BarCharts/>
                <PieCharts width={"50%"}/>
            </CardsContainer>
            <CardsContainer style={{marginTop:"24px"}}>
                <Table width={"75%"}/>
                <PieCharts width={"25%"}/>
            </CardsContainer>

        
        </>
    )
}   


export default DashBoard