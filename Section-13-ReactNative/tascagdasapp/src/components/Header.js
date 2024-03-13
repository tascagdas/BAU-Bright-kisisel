import { Button, StyleSheet, Text, View } from 'react-native'
import React, { useState } from 'react'

const Header = (props) => {

    const [fullName, setfullName] = useState("Cagdas")


    let name = "Cagdas";



    const changeName = () => {
        // name = "cagdastas"
        setfullName("Cagdas Tas")
    }

    return (
        <View>
            <Text>{props.isim}</Text>
            <Text style={styles.name}>{fullName}</Text>
            <Button
                title={"Click"}
                onPress={changeName}
            />
        </View>
    )
}

export default Header

const styles = StyleSheet.create({
    name: {
        fontSize: 40,
        color: "red",
        textAlign: "center"
    }
})