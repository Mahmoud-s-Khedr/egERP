import styled from "styled-components"
import TaskList from "../Components/TaskList"
import { useState } from "react"
import useTheme from "../Context/useTheme";

const Container = styled.div`
    display:flex;

    gap: 24px;
`

function Tasks() {
    const [selectedTask, setSelectedTask] = useState(null);
    const {theme} = useTheme();
    return (
        <Container>
            <TaskList selectedTask={selectedTask} setSelectedTask={setSelectedTask} color={theme.red}/>
            <TaskList selectedTask={selectedTask} setSelectedTask={setSelectedTask} color={theme.primary}/>
            <TaskList selectedTask={selectedTask} setSelectedTask={setSelectedTask} color={theme.secondary}/>
        </Container>
    )
}

export default Tasks