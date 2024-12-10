import styled from "styled-components"
import useTheme from "../Context/useTheme"
const CardContainer = styled.div`
    display:flex;
    flex-direction: column;
    flex-wrap: wrap;
    width: calc(100%/3 - 24px);
    padding: 16px 24px;
    background-color: ${({theme}) => theme.ComponentBackground};
    color: ${({theme}) => theme.text};
    border-radius: 8px;
    gap: 10px;
`

const CardHeader = styled.header`
    width: 100%;
    display: flex;
    justify-content: space-between;
    font-size: 32px;

`
const CardBody = styled.div`
    width: 100%;
    display: flex;
    justify-content: center;
    font-size: 42px;
`

const CardFooter = styled.footer`
    width: 100%;
    display: flex;
    justify-content: space-between;
    font-size: 20px;
`

const Color = styled.div`
    color: ${props => props.color};
`

function DashBoardCard({header,icon,body,footer,footervalue,color}) {
    const {theme} = useTheme();
    return (
        <CardContainer theme={theme}>
            <CardHeader>
                <div>{header}</div>
                <Color color={color}>{icon}</Color>
            </CardHeader>
            <CardBody>
                <Color color={color}>{body}</Color>
            </CardBody>
            <CardFooter>
                <Color color={theme.lightgray}>{footer}</Color>
                <Color color={color}>{footervalue}</Color>
            </CardFooter>
        </CardContainer>
    )
}

export default DashBoardCard