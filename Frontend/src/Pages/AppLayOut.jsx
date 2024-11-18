
import { Outlet } from 'react-router-dom'
import TextControlsExample from '../Components/TextControlsExample'

export default function AppLayOut() {
    return (
        <div className="App">
            <div className="App-header">
                <TextControlsExample/>
                <Outlet/>
            </div>
        </div>
    )
}