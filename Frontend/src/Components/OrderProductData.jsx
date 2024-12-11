import styled from "styled-components"
import useTheme from "../Context/useTheme"

const Container = styled.div`
    display:flex;
    flex-direction: row;
    flex-wrap: wrap;
    margin: 24px 0px;
    width:calc(100% - 48px);
    padding: 16px 24px;
    background-color: ${({theme}) => theme.ComponentBackground};
    color: ${({theme}) => theme.text};
    border-radius: 8px;
    gap: 24px;
`

const NameContainer = styled.div`
    font-size: 24px;
    color: ${({theme}) => theme.text};
    gap: 12px;
    width: calc(50% - 24px);
    span{
        color: ${({theme}) => theme.lightgraynav};
    }
`

const DescriptionContainer = styled.div`
    font-size: 20px;
    color: ${({theme}) => theme.text};
    width: 100%;
    gap: 12px;
    span{
        color: ${({theme}) => theme.lightgraynav};
    }
`
function OrderProductData() {
    const {theme} = useTheme()
    return (
        <Container theme={theme}>
            <NameContainer theme={theme}><span >
                Product Name : </span> Lorem ipsum dolor sit amet consectetur adipisicing elit
                 </NameContainer>
            <NameContainer theme={theme}><span >
                 Price : </span> 1200$
            </NameContainer>
            <DescriptionContainer theme={theme}>
                <span>Description : </span> Lorem ipsum dolor sit amet consectetur Lorem ipsum, dolor sit amet consectetur adipisicing elit. Asperiores, cumque nostrum expedita vitae eveniet perferendis perspiciatis ducimus molestiae suscipit similique! adipisicing elit
                 . Quisquam, quae
                .</DescriptionContainer>
        </Container>
    )
}

export default OrderProductData