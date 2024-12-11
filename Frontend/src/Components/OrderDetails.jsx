import styled from "styled-components"
import useTheme from "../Context/useTheme"
import { MdOutlineInventory2, MdOutlineCalendarToday, MdOutlinePayments, 
         MdOutlineLocalShipping, MdOutlineCreditCard, MdOutlineShoppingCart } from 'react-icons/md'

const Container = styled.div`
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    margin: 24px 0px;
    padding: 24px;
    background-color: ${({theme}) => theme.ComponentBackground};
    color: ${({theme}) => theme.text};
    border-radius: 12px;
    gap: 32px;
    box-shadow: 0 2px 4px rgba(0,0,0,0.1);
`

const DetailItem = styled.div`
    width: calc(100% / 3 - 32px);
    min-width: 300px;
    display: flex;
    align-items: center;
    gap: 16px;
    svg {
        font-size: 40px;
        color: ${({theme}) => theme.primary};
    }
`

const Label = styled.span`
    font-size: 24px;
    color: ${({theme}) => theme.lightgraynav};
    margin: 6px 0px;
    display: block;
`

const Value = styled.div`
    font-size: 28px;
    font-weight: 500;
    margin-top: 4px;
    color: ${({theme}) => theme.text};
`

const StatusBadge = styled.div`
    padding: 6px 12px;
    border-radius: 20px;
    font-size: 14px;
    font-weight: 500;
    background-color: ${({status, theme}) => {
        switch(status.toLowerCase()) {
            case 'pending':
                return '#FFF3DC';
            case 'completed':
                return '#DCF7E3';
            case 'cancelled':
                return '#FFE2E2';
            default:
                return theme.ComponentBackground;
        }
    }};
    color: ${({status}) => {
        switch(status.toLowerCase()) {
            case 'pending':
                return '#FF9800';
            case 'completed':
                return '#2E7D32';
            case 'cancelled':
                return '#D32F2F';
            default:
                return '#666666';
        }
    }};
`

const Content = styled.div`
    display: flex;
    flex-direction: column;
`

function OrderDetails() {
    const {theme} = useTheme()
    return (
        <Container theme={theme}>
            <DetailItem theme={theme}>
                <MdOutlineInventory2 />
                <Content>
                    <Label theme={theme}>Order Number</Label>
                    <Value>ORD-004</Value>
                </Content>
            </DetailItem>
            
            <DetailItem theme={theme}>
                <MdOutlinePayments />
                <Content>
                    <Label theme={theme}>Price</Label>
                    <Value>$1,200</Value>
                </Content>
            </DetailItem>
            
            <DetailItem theme={theme}>
                <MdOutlineShoppingCart />
                <Content>
                    <Label theme={theme}>Quantity</Label>
                    <Value>2</Value>
                </Content>
            </DetailItem>
            
            <DetailItem theme={theme}>
                <MdOutlineCalendarToday />
                <Content>
                    <Label theme={theme}>Date</Label>
                    <Value>Dec 9, 2023</Value>
                </Content>
            </DetailItem>
            
            <DetailItem theme={theme}>
                <MdOutlineCreditCard />
                <Content>
                    <Label theme={theme}>Payment Method</Label>
                    <Value>Cash on Delivery</Value>
                </Content>
            </DetailItem>
            
            <DetailItem theme={theme}>
                <MdOutlinePayments />
                <Content>
                    <Label theme={theme}>Payment Status</Label>
                    <StatusBadge status="pending" theme={theme}>Pending</StatusBadge>
                </Content>
            </DetailItem>
            
            <DetailItem theme={theme}>
                <MdOutlineLocalShipping />
                <Content>
                    <Label theme={theme}>Shipping Status</Label>
                    <StatusBadge status="pending" theme={theme}>Pending</StatusBadge>
                </Content>
            </DetailItem>
        </Container>
    )
}

export default OrderDetails