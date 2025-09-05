import { Group } from "@mui/icons-material";
import { AppBar, Box, Button, Toolbar, Typography, Container, MenuItem } from "@mui/material";

type Props = {
    openForm: () => void;
}

export default function NavBar({openForm}: Props) {
  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static" sx={{backgroundImage: 'linear-gradient(to right, #182a73 0%, #218aae 69%, #20a7ac 89%)'

      }}>
        <Container maxWidth="xl">
                  <Toolbar sx={{ display: 'flex', justifyContent: 'space-between' }}>
                      <Box>
                          <MenuItem sx={{ display: 'flex', gap: 2 }}>
                              <Group fontSize="large" />
                              <Typography variant="h4" fontWeight='bold'>EngageHub</Typography>
                            </MenuItem>
                  </Box>
                  <Box sx={{ display: 'flex', gap: 4 }}>
                    <MenuItem sx={{ 
                        fontsize: '1.2rem', textTransform: 'uppercase', fontWeight: 'bold' }}>Activities</MenuItem>
                        <MenuItem sx={{ 
                        fontsize: '1.2rem', textTransform: 'uppercase', fontWeight: 'bold' }}>About</MenuItem>
                        <MenuItem sx={{ 
                        fontsize: '1.2rem', textTransform: 'uppercase', fontWeight: 'bold' }}>Contact Us</MenuItem>
                  </Box>
                  <Button onClick={openForm} size='large' variant="contained" sx={{ backgroundColor: 'white', color: '#182a73', fontWeight: 'bold', '&:hover': { backgroundColor: '#f0f0f0' } }}>Create Activity</Button>
              </Toolbar>
        </Container>
      </AppBar>
    </Box>
  )
}
