import { Button, StyleSheet, Text, View } from 'react-native'
import React, { useState } from 'react'

const Main = (props) => {
    let { mainText } = props;
    const [counter, setcounter] = useState(0)
    const increment = () => {
        if (counter < 10) {
            setcounter(counter + 1)
        }

    }
    const decrement = () => {
        if (counter > 0) {
            setcounter(counter - 1)
        }

    }
    return (
        <View>
            <Text>{mainText}</Text>
            <Text style={styles.counterText} >{counter}</Text>
            <Button title='+' onPress={increment} />
            <Button title='-' onPress={decrement} />
        </View>
    )
}

export default Main

const styles = StyleSheet.create({
    counterText: {
        color: "green",
        fontSize: 40,
        textAlign: "center",
        marginVertical: 15

    }
})