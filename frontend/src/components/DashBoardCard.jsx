import styled from "styled-components"



const Card=styled.div`
    display: flex;
    align-items: center;
    flex-wrap: wrap;
    height: 150px;
    
    background-color: ${({theme})=>theme.componentBackground};
    border-radius: 10px;
    margin-right: 20px;
    box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
    padding: 20px;

    @media (max-width: 768px) {
        margin-top: 10px;
        width: 100%;
    }
    
`;

const CardHeader=styled.header`
    display: flex;
    flex-direction: row;
    font-size: 20px;
    width: 70%;
    justify-content: space-between;
    align-items: center;
`;

const Icon=styled.div`
    width: 30%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    font-size: 50px;
    height: 100%;
    color: ${(prop)=>prop.color};
`;

const Description=styled.div`
    width: 70%;
    font-size: 15px;
    color: ${(prop)=>prop.color};
`;
const Value=styled.div`
    width: 70%;
    font-size: 25px;
    color: ${(prop)=>prop.color};
`;
const RightSide=styled.div`
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 100%;
    width: 70%;

`;
function  DashboardCard({title, value, color, icon}) {
    return (
        <Card>
            <RightSide>
            <CardHeader>{title}</CardHeader>
            <Value color={color}> {value}</Value>
            <Description ><span style={{color:color}}>+12%</span> from last month</Description>
            </RightSide>
            <Icon color={color}>{icon}</Icon>
            
        </Card>
    )
}

export default DashboardCard


