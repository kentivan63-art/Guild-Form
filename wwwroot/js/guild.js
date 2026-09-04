// Guild Registry JavaScript Functions
// Handles localStorage persistence and medieval interactions

const GUILD_PETITIONS_KEY = 'guild_petitions';

/**
 * Save a petition to localStorage
 * @param {Object} petitioner - The petitioner object to save
 */
function savePetition(petitioner) {
    try {
        const petitions = getPetitions();
        petitioner.id = Date.now(); // Generate unique ID
        petitions.push(petitioner);
        localStorage.setItem(GUILD_PETITIONS_KEY, JSON.stringify(petitions));
        return true;
    } catch (error) {
        console.error('Error saving petition:', error);
        return false;
    }
}

/**
 * Get all petitions from localStorage
 * @returns {Array} Array of petitioner objects
 */
function getPetitions() {
    try {
        const stored = localStorage.getItem(GUILD_PETITIONS_KEY);
        return stored ? JSON.parse(stored) : [];
    } catch (error) {
        console.error('Error retrieving petitions:', error);
        return [];
    }
}

/**
 * Update a petition in localStorage
 * @param {number} id - The petition ID to update
 * @param {Object} updatedData - The updated petition data
 */
function updatePetition(id, updatedData) {
    try {
        const petitions = getPetitions();
        const index = petitions.findIndex(p => p.id === id);
        if (index !== -1) {
            petitions[index] = { ...petitions[index], ...updatedData };
            localStorage.setItem(GUILD_PETITIONS_KEY, JSON.stringify(petitions));
            return true;
        }
        return false;
    } catch (error) {
        console.error('Error updating petition:', error);
        return false;
    }
}

/**
 * Delete a petition from localStorage
 * @param {number} id - The petition ID to delete
 */
function deletePetition(id) {
    try {
        const petitions = getPetitions();
        const filtered = petitions.filter(p => p.id !== id);
        localStorage.setItem(GUILD_PETITIONS_KEY, JSON.stringify(filtered));
        return true;
    } catch (error) {
        console.error('Error deleting petition:', error);
        return false;
    }
}

/**
 * Filter petitions by search term and guild
 * @param {string} searchTerm - The search term
 * @param {number} guildId - The guild ID to filter by (optional)
 * @returns {Array} Filtered array of petitions
 */
function filterPetitions(searchTerm, guildId) {
    const petitions = getPetitions();
    const term = searchTerm.toLowerCase();
    
    return petitions.filter(petitioner => {
        const matchesSearch = !term || 
            petitioner.fullName.toLowerCase().includes(term) ||
            petitioner.townOrBorough.toLowerCase().includes(term) ||
            petitioner.registrationCode.toLowerCase().includes(term);
        
        const matchesGuild = !guildId || petitioner.selectedGuildId === parseInt(guildId);
        
        return matchesSearch && matchesGuild;
    });
}

/**
 * Get petitions by guild ID
 * @param {number} guildId - The guild ID
 * @returns {Array} Array of petitions for the specified guild
 */
function getPetitionsByGuild(guildId) {
    const petitions = getPetitions();
    return petitions.filter(p => p.selectedGuildId === parseInt(guildId));
}

/**
 * Clear all petitions from localStorage
 * Use with caution - this is for testing purposes
 */
function clearAllPetitions() {
    try {
        localStorage.removeItem(GUILD_PETITIONS_KEY);
        return true;
    } catch (error) {
        console.error('Error clearing petitions:', error);
        return false;
    }
}

/**
 * Generate a unique registration code
 * @param {string} guildName - The guild name
 * @returns {string} Registration code
 */
function generateRegistrationCode(guildName) {
    const guildAcronym = guildName.substring(0, 3).toUpperCase();
    const timestamp = Date.now().toString(36).toUpperCase();
    const random = Math.random().toString(36).substring(2, 5).toUpperCase();
    return `SIGIL-${guildAcronym}-${timestamp}${random}`;
}

/**
 * Medieval sound effects (for future enhancement)
 */
const MedievalSounds = {
    quillScratch: () => {
        // Future: Play subtle quill scratching sound
        console.log('Quill scratching sound');
    },
    
    waxSeal: () => {
        // Future: Play wax seal thud sound
        console.log('Wax seal thud sound');
    },
    
    parchmentUnroll: () => {
        // Future: Play parchment unroll sound
        console.log('Parchment unroll sound');
    }
};

/**
 * Initialize medieval interactions
 */
function initializeMedievalInteractions() {
    // Add quill sound effect to text inputs
    const textInputs = document.querySelectorAll('.quill-input, .quill-textarea');
    textInputs.forEach(input => {
        input.addEventListener('input', () => {
            MedievalSounds.quillScratch();
        });
    });
    
    // Add wax seal sound effect to seal buttons
    const sealButtons = document.querySelectorAll('.wax-seal-btn');
    sealButtons.forEach(button => {
        button.addEventListener('click', () => {
            MedievalSounds.waxSeal();
        });
    });
}

// Initialize when DOM is ready
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', initializeMedievalInteractions);
} else {
    initializeMedievalInteractions();
}