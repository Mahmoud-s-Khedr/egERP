import DashboardCard from "../components/DashBoardCard";
import OrdersBarChart from "../components/OrdersBarChart";
import styled from "styled-components";
import { FaDollarSign, FaUsers } from "react-icons/fa";
import { CgShoppingCart } from "react-icons/cg";
import { GiCash } from "react-icons/gi";
import CustomersTable from "../components/CustomersTable";
import PieChartComponent from "../components/PieChartComponent";
import { ComposedChart } from "recharts";
import CompositeChart from "../components/CompositeChart";
const DashBoardWrapper=styled.div`
    display: flex;
    flex-wrap: wrap;
    flex-direction:row ;
    height: 100%;
    width: 100%;
`;

const BarChartWrapper=styled.div`
    display: flex;
    flex-direction:column ;
    flex-wrap: wrap;
    height: 400px;
    background: ${({theme})=>theme.componentBackground};
    width: 50%;
    border: 1px solid #ccc;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
    @media (max-width: 768px) {
        width: 100%;
        
    }
`;

const CardsWrapper=styled.div`
    display: flex;
    flex-direction:column ;
    flex-wrap: wrap;
    justify-content: space-between;
    height: 400px;
    padding-right: 9px;
    width: calc(25% - 20px);
    border-radius: 10px;
    margin-left: 10px;
    @media (max-width: 768px) {
        width: 100%;
        flex-direction: row;
        margin-top: 20px;
        height: fit-content;
        
    }
`;

const RoWrapper=styled.div`
    display: flex;
    flex-direction:row ;
    flex-wrap: wrap;
    margin-top: 10px;
    width: 100%;
    @media (max-width: 768px) {
        

    }
`;

const TableWrapper=styled.div`
    display: flex;
    flex-direction:column ;
    flex-wrap: wrap;
    height: 400px;
    background: ${({theme})=>theme.componentBackground};
    width: 50%;
    border: 1px solid #ccc;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
    @media (max-width: 768px) {
        width: 100%;

    }
`;

const Header=styled.header`
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    padding: 10px;
    font-size: 20px;
    width: 100%;
    justify-content: center;
    align-items: center;
    @media (max-width: 768px) {
        padding: 0px;
    }
`;

const Footer=styled.footer`
    margin-top: 20px;
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    padding: 10px;
    font-size: 20px;
    width: 100%;
    justify-content: center;
    align-items: center;
    border-radius: 10px;
    background-color: ${({theme})=>theme.componentBackground};
    box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
`;

const PieChartWrapper=styled.div`
    display: flex;  
    flex-direction:column ;
    flex-wrap: wrap;
    height: 400px;
    background: ${({theme})=>theme.componentBackground};
    width: 100%;
    margin-right: 10px;
    border: 1px solid #ccc;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
    @media (max-width: 768px) {
        width: 100%;

    }    
`;
function DashBoard() {
    return (
        <DashBoardWrapper>
            <RoWrapper>
            <BarChartWrapper>
                <OrdersBarChart/>
            </BarChartWrapper>
            <CardsWrapper>
                <DashboardCard title="Customers" value="100" description="" icon={<FaUsers />}/>
                <DashboardCard title="Revenue" value="$1000" description="" icon={<FaDollarSign />}/>
            </CardsWrapper>
            <CardsWrapper>
                <DashboardCard title="Orders" value="100" description="" icon={<CgShoppingCart />}/>
                <DashboardCard title="Sales" value="$1000" description="" icon={<GiCash />}/>
            </CardsWrapper>
            </RoWrapper>
            <RoWrapper>
            <TableWrapper>
                <Header>Top 5 Customers</Header>
                <CustomersTable/>
            </TableWrapper>
            <CardsWrapper>
                <PieChartWrapper>
                    <PieChartComponent/>    
                </PieChartWrapper>
                <PieChartWrapper>
                    <PieChartComponent/>    
                </PieChartWrapper>
            </CardsWrapper>
            </RoWrapper>
            <Footer>
                <CompositeChart/>
            </Footer>
   
        </DashBoardWrapper>
    )
}

export default DashBoard;