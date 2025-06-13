using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Actions;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Responses
{
	// Token: 0x0200030E RID: 782
	public class NPCResponses : MonoBehaviour
	{
		// Token: 0x06003A11 RID: 14865 RVA: 0x001308EC File Offset: 0x0012EAEC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses()
		{
			Il2CppClassPointerStore<NPCResponses>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Responses", "NPCResponses");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr);
			NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "ASSAULT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "DEADLYASSAULT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "AIMED_AT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "PICKPOCKET_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr__npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "<npc>k__BackingField");
			NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "timeSinceLastImpact");
			NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "timeSinceAimedAt");
			NPCResponses.NativeMethodInfoPtr_get_npc_Protected_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670127);
			NPCResponses.NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670128);
			NPCResponses.NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670129);
			NPCResponses.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670130);
			NPCResponses.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670131);
			NPCResponses.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670132);
			NPCResponses.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670133);
			NPCResponses.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670134);
			NPCResponses.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670135);
			NPCResponses.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670136);
			NPCResponses.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670137);
			NPCResponses.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670138);
			NPCResponses.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670139);
			NPCResponses.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670140);
			NPCResponses.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670141);
			NPCResponses.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670142);
			NPCResponses.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670143);
			NPCResponses.NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670144);
			NPCResponses.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670145);
			NPCResponses.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670146);
			NPCResponses.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670147);
			NPCResponses.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670148);
			NPCResponses.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670149);
			NPCResponses.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670150);
			NPCResponses.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100670151);
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x00130B9C File Offset: 0x0012ED9C
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x00130BDC File Offset: 0x0012EDDC
		public unsafe NPC npc
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_get_npc_Protected_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x00130C20 File Offset: 0x0012EE20
		public unsafe NPCActions actions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCActions>(intPtr2) : null;
			}
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00130C60 File Offset: 0x0012EE60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147009, RefRangeEnd = 147010, XrefRangeStart = 147005, XrefRangeEnd = 147009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x00130C9C File Offset: 0x0012EE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147010, XrefRangeEnd = 147012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00130CD8 File Offset: 0x0012EED8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GunshotHeard(NoiseEvent gunshotSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gunshotSound);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00130D28 File Offset: 0x0012EF28
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExplosionHeard(NoiseEvent explosionSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(explosionSound);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00130D78 File Offset: 0x0012EF78
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedPettyCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x00130DC8 File Offset: 0x0012EFC8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedVandalism(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x00130E18 File Offset: 0x0012F018
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SawPickpocketing(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x00130E68 File Offset: 0x0012F068
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticePlayerBrandishingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00130EB8 File Offset: 0x0012F0B8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticePlayerDischargingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00130F08 File Offset: 0x0012F108
		[CallerCount(0)]
		public unsafe virtual void PlayerFailedPickpocket(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00130F58 File Offset: 0x0012F158
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedDrugDeal(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00130FA8 File Offset: 0x0012F1A8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedViolatingCurfew(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00130FF8 File Offset: 0x0012F1F8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedWantedPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00131048 File Offset: 0x0012F248
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedSuspiciousPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x00131098 File Offset: 0x0012F298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147037, RefRangeEnd = 147038, XrefRangeStart = 147012, XrefRangeEnd = 147037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x001310E8 File Offset: 0x0012F2E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147045, RefRangeEnd = 147046, XrefRangeStart = 147038, XrefRangeEnd = 147045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ImpactReceived(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x00131138 File Offset: 0x0012F338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147046, RefRangeEnd = 147048, XrefRangeStart = 147046, XrefRangeEnd = 147046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x00131198 File Offset: 0x0012F398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147048, RefRangeEnd = 147050, XrefRangeStart = 147048, XrefRangeEnd = 147048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x001311F8 File Offset: 0x0012F3F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147050, RefRangeEnd = 147052, XrefRangeStart = 147050, XrefRangeEnd = 147050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x00131258 File Offset: 0x0012F458
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x001312B8 File Offset: 0x0012F4B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147052, RefRangeEnd = 147053, XrefRangeStart = 147052, XrefRangeEnd = 147052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToAimedAt(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x00131308 File Offset: 0x0012F508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147054, RefRangeEnd = 147056, XrefRangeStart = 147053, XrefRangeEnd = 147054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x0001DBA5 File Offset: 0x0001BDA5
		public NPCResponses(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06003A2C RID: 14892 RVA: 0x00131344 File Offset: 0x0012F544
		// (set) Token: 0x06003A2D RID: 14893 RVA: 0x0001DBAE File Offset: 0x0001BDAE
		public unsafe static float ASSAULT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06003A2E RID: 14894 RVA: 0x00131360 File Offset: 0x0012F560
		// (set) Token: 0x06003A2F RID: 14895 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		public unsafe static float DEADLYASSAULT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06003A30 RID: 14896 RVA: 0x0013137C File Offset: 0x0012F57C
		// (set) Token: 0x06003A31 RID: 14897 RVA: 0x0001DBCA File Offset: 0x0001BDCA
		public unsafe static float AIMED_AT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x00131398 File Offset: 0x0012F598
		// (set) Token: 0x06003A33 RID: 14899 RVA: 0x0001DBD8 File Offset: 0x0001BDD8
		public unsafe static float PICKPOCKET_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06003A34 RID: 14900 RVA: 0x001313B4 File Offset: 0x0012F5B4
		// (set) Token: 0x06003A35 RID: 14901 RVA: 0x0001DBE6 File Offset: 0x0001BDE6
		public unsafe NPC _npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr__npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr__npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06003A36 RID: 14902 RVA: 0x001313E4 File Offset: 0x0012F5E4
		// (set) Token: 0x06003A37 RID: 14903 RVA: 0x0001DC05 File Offset: 0x0001BE05
		public unsafe float timeSinceLastImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact)) = value;
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x0013140C File Offset: 0x0012F60C
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x0001DC20 File Offset: 0x0001BE20
		public unsafe float timeSinceAimedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt)) = value;
			}
		}

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeFieldInfoPtr__npc_k__BackingField;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastImpact;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceAimedAt;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_get_npc_Protected_get_NPC_0;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0;

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400265D RID: 9821
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0;

		// Token: 0x0400265E RID: 9822
		private static readonly IntPtr NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400265F RID: 9823
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
