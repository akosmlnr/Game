using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.FX;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000616 RID: 1558
	public class AvatarEffects : MonoBehaviour
	{
		// Token: 0x0600879A RID: 34714 RVA: 0x00241364 File Offset: 0x0023F564
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEffects()
		{
			Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr);
			AvatarEffects.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "Avatar");
			AvatarEffects.NativeFieldInfoPtr_StinkParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "StinkParticles");
			AvatarEffects.NativeFieldInfoPtr_VomitParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "VomitParticles");
			AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadPoofParticles");
			AvatarEffects.NativeFieldInfoPtr_FartParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FartParticles");
			AvatarEffects.NativeFieldInfoPtr_AntiGravParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AntiGravParticles");
			AvatarEffects.NativeFieldInfoPtr_FireParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireParticles");
			AvatarEffects.NativeFieldInfoPtr_FireLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireLight");
			AvatarEffects.NativeFieldInfoPtr_FoggyEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FoggyEffects");
			AvatarEffects.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadBone");
			AvatarEffects.NativeFieldInfoPtr_NeckBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "NeckBone");
			AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "MirrorEffectsTo");
			AvatarEffects.NativeFieldInfoPtr_ZapParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapParticles");
			AvatarEffects.NativeFieldInfoPtr_CountdownExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "CountdownExplosion");
			AvatarEffects.NativeFieldInfoPtr_ObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ObjectsToCull");
			AvatarEffects.NativeFieldInfoPtr_DisableHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "DisableHead");
			AvatarEffects.NativeFieldInfoPtr_GurgleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "GurgleSound");
			AvatarEffects.NativeFieldInfoPtr_VomitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "VomitSound");
			AvatarEffects.NativeFieldInfoPtr_PoofSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "PoofSound");
			AvatarEffects.NativeFieldInfoPtr_FartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FartSound");
			AvatarEffects.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireSound");
			AvatarEffects.NativeFieldInfoPtr_ZapSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapSound");
			AvatarEffects.NativeFieldInfoPtr_ZapLoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapLoopSound");
			AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AdditionalWeightController");
			AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AdditionalGenderController");
			AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadSizeBoost");
			AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "NeckSizeBoost");
			AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "SkinColorSmoother");
			AvatarEffects.NativeFieldInfoPtr_laxativeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "laxativeEnabled");
			AvatarEffects.NativeFieldInfoPtr_currentEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "currentEmission");
			AvatarEffects.NativeFieldInfoPtr_targetEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "targetEmission");
			AvatarEffects.NativeFieldInfoPtr_isCulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "isCulled");
			AvatarEffects.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680338);
			AvatarEffects.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680339);
			AvatarEffects.NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680340);
			AvatarEffects.NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680341);
			AvatarEffects.NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680342);
			AvatarEffects.NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680343);
			AvatarEffects.NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680344);
			AvatarEffects.NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680345);
			AvatarEffects.NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680346);
			AvatarEffects.NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680347);
			AvatarEffects.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680348);
			AvatarEffects.NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680349);
			AvatarEffects.NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680350);
			AvatarEffects.NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680351);
			AvatarEffects.NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680352);
			AvatarEffects.NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680353);
			AvatarEffects.NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680354);
			AvatarEffects.NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680355);
			AvatarEffects.NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680356);
			AvatarEffects.NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680357);
			AvatarEffects.NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680358);
			AvatarEffects.NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680359);
			AvatarEffects.NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680360);
			AvatarEffects.NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680361);
			AvatarEffects.NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680362);
			AvatarEffects.NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680363);
			AvatarEffects.NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680364);
			AvatarEffects.NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680365);
			AvatarEffects.NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680366);
			AvatarEffects.NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680367);
			AvatarEffects.NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680368);
			AvatarEffects.NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680369);
			AvatarEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680370);
			AvatarEffects.NativeMethodInfoPtr__Start_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680371);
			AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680372);
			AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100680373);
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x002418E4 File Offset: 0x0023FAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254003, XrefRangeEnd = 254025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x00241918 File Offset: 0x0023FB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254025, XrefRangeEnd = 254065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x0024194C File Offset: 0x0023FB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254065, XrefRangeEnd = 254067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEffectsCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref culled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x0024198C File Offset: 0x0023FB8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254073, RefRangeEnd = 254078, XrefRangeStart = 254067, XrefRangeEnd = 254073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStinkParticlesActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x002419D8 File Offset: 0x0023FBD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 254088, RefRangeEnd = 254095, XrefRangeStart = 254078, XrefRangeEnd = 254088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSick(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x00241A18 File Offset: 0x0023FC18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254098, RefRangeEnd = 254103, XrefRangeStart = 254095, XrefRangeEnd = 254098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAntiGrav(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x00241A64 File Offset: 0x0023FC64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254106, RefRangeEnd = 254111, XrefRangeStart = 254103, XrefRangeEnd = 254106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFoggy(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A2 RID: 34722 RVA: 0x00241AB0 File Offset: 0x0023FCB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254119, RefRangeEnd = 254122, XrefRangeStart = 254111, XrefRangeEnd = 254119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VanishHair(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A3 RID: 34723 RVA: 0x00241AF0 File Offset: 0x0023FCF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254133, RefRangeEnd = 254139, XrefRangeStart = 254122, XrefRangeEnd = 254133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZapped(bool zapped, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref zapped;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A4 RID: 34724 RVA: 0x00241B3C File Offset: 0x0023FD3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254147, RefRangeEnd = 254150, XrefRangeStart = 254139, XrefRangeEnd = 254147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnHair(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A5 RID: 34725 RVA: 0x00241B7C File Offset: 0x0023FD7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254154, RefRangeEnd = 254157, XrefRangeStart = 254150, XrefRangeEnd = 254154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideHairColor(Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A6 RID: 34726 RVA: 0x00241BC8 File Offset: 0x0023FDC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254161, RefRangeEnd = 254164, XrefRangeStart = 254157, XrefRangeEnd = 254161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHairColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A7 RID: 34727 RVA: 0x00241C08 File Offset: 0x0023FE08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254168, RefRangeEnd = 254173, XrefRangeStart = 254164, XrefRangeEnd = 254168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeColor(Color color, float emission = 0.115f, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref emission;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x00241C64 File Offset: 0x0023FE64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254177, RefRangeEnd = 254182, XrefRangeStart = 254173, XrefRangeEnd = 254177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x00241CA4 File Offset: 0x0023FEA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254186, RefRangeEnd = 254191, XrefRangeStart = 254182, XrefRangeEnd = 254186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLightEmission(float intensity, Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref color;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x00241D00 File Offset: 0x0023FF00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254205, RefRangeEnd = 254208, XrefRangeStart = 254191, XrefRangeEnd = 254205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableLaxative(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x00241D40 File Offset: 0x0023FF40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254210, RefRangeEnd = 254213, XrefRangeStart = 254208, XrefRangeEnd = 254210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableLaxative(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x00241D80 File Offset: 0x0023FF80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254216, RefRangeEnd = 254221, XrefRangeStart = 254213, XrefRangeEnd = 254216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFireActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x00241DCC File Offset: 0x0023FFCC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254229, RefRangeEnd = 254234, XrefRangeStart = 254221, XrefRangeEnd = 254229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBigHeadActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x00241E18 File Offset: 0x00240018
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254246, RefRangeEnd = 254251, XrefRangeStart = 254234, XrefRangeEnd = 254246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGiraffeActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x00241E64 File Offset: 0x00240064
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254264, RefRangeEnd = 254269, XrefRangeStart = 254251, XrefRangeEnd = 254264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkinColorInverted(bool inverted, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref inverted;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x00241EB0 File Offset: 0x002400B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254282, RefRangeEnd = 254287, XrefRangeStart = 254269, XrefRangeEnd = 254282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSicklySkinColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x00241EF0 File Offset: 0x002400F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254294, RefRangeEnd = 254297, XrefRangeStart = 254287, XrefRangeEnd = 254294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultSkinColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x00241F30 File Offset: 0x00240130
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254307, RefRangeEnd = 254312, XrefRangeStart = 254297, XrefRangeEnd = 254307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGenderInverted(bool inverted, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref inverted;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x00241F7C File Offset: 0x0024017C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254315, RefRangeEnd = 254318, XrefRangeStart = 254312, XrefRangeEnd = 254315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAdditionalWeightOverride(float value, int priority, string label, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x00241FE8 File Offset: 0x002401E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254321, RefRangeEnd = 254324, XrefRangeStart = 254318, XrefRangeEnd = 254321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAdditionalWeightOverride(string label, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x00242038 File Offset: 0x00240238
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254326, RefRangeEnd = 254329, XrefRangeStart = 254324, XrefRangeEnd = 254326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlowingOn(Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x00242084 File Offset: 0x00240284
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254331, RefRangeEnd = 254334, XrefRangeStart = 254329, XrefRangeEnd = 254331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlowingOff(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x002420C4 File Offset: 0x002402C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254337, RefRangeEnd = 254340, XrefRangeStart = 254334, XrefRangeEnd = 254337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerCountdownExplosion(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B8 RID: 34744 RVA: 0x00242104 File Offset: 0x00240304
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254343, RefRangeEnd = 254346, XrefRangeStart = 254340, XrefRangeEnd = 254343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCountdownExplosion(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087B9 RID: 34745 RVA: 0x00242144 File Offset: 0x00240344
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254365, RefRangeEnd = 254370, XrefRangeStart = 254346, XrefRangeEnd = 254365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCyclopean(bool enabled, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087BA RID: 34746 RVA: 0x00242190 File Offset: 0x00240390
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254395, RefRangeEnd = 254400, XrefRangeStart = 254370, XrefRangeEnd = 254395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZombified(bool zombified, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref zombified;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mirror;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087BB RID: 34747 RVA: 0x002421DC File Offset: 0x002403DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254400, XrefRangeEnd = 254401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEffects() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087BC RID: 34748 RVA: 0x00242218 File Offset: 0x00240418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254401, XrefRangeEnd = 254402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__32_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr__Start_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060087BD RID: 34749 RVA: 0x0024224C File Offset: 0x0024044C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254402, XrefRangeEnd = 254407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060087BE RID: 34750 RVA: 0x0024228C File Offset: 0x0024048C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254407, XrefRangeEnd = 254412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060087BF RID: 34751 RVA: 0x000401BD File Offset: 0x0003E3BD
		public AvatarEffects(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x060087C0 RID: 34752 RVA: 0x002422CC File Offset: 0x002404CC
		// (set) Token: 0x060087C1 RID: 34753 RVA: 0x000401C6 File Offset: 0x0003E3C6
		public unsafe Avatar Avatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_Avatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x060087C2 RID: 34754 RVA: 0x002422FC File Offset: 0x002404FC
		// (set) Token: 0x060087C3 RID: 34755 RVA: 0x000401E5 File Offset: 0x0003E3E5
		public unsafe Il2CppReferenceArray<ParticleSystem> StinkParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_StinkParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_StinkParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x060087C4 RID: 34756 RVA: 0x0024232C File Offset: 0x0024052C
		// (set) Token: 0x060087C5 RID: 34757 RVA: 0x00040204 File Offset: 0x0003E404
		public unsafe ParticleSystem VomitParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x060087C6 RID: 34758 RVA: 0x0024235C File Offset: 0x0024055C
		// (set) Token: 0x060087C7 RID: 34759 RVA: 0x00040223 File Offset: 0x0003E423
		public unsafe ParticleSystem HeadPoofParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x060087C8 RID: 34760 RVA: 0x0024238C File Offset: 0x0024058C
		// (set) Token: 0x060087C9 RID: 34761 RVA: 0x00040242 File Offset: 0x0003E442
		public unsafe ParticleSystem FartParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x060087CA RID: 34762 RVA: 0x002423BC File Offset: 0x002405BC
		// (set) Token: 0x060087CB RID: 34763 RVA: 0x00040261 File Offset: 0x0003E461
		public unsafe ParticleSystem AntiGravParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AntiGravParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AntiGravParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x002423EC File Offset: 0x002405EC
		// (set) Token: 0x060087CD RID: 34765 RVA: 0x00040280 File Offset: 0x0003E480
		public unsafe ParticleSystem FireParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x060087CE RID: 34766 RVA: 0x0024241C File Offset: 0x0024061C
		// (set) Token: 0x060087CF RID: 34767 RVA: 0x0004029F File Offset: 0x0003E49F
		public unsafe OptimizedLight FireLight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireLight);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x060087D0 RID: 34768 RVA: 0x0024244C File Offset: 0x0024064C
		// (set) Token: 0x060087D1 RID: 34769 RVA: 0x000402BE File Offset: 0x0003E4BE
		public unsafe ParticleSystem FoggyEffects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FoggyEffects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FoggyEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x060087D2 RID: 34770 RVA: 0x0024247C File Offset: 0x0024067C
		// (set) Token: 0x060087D3 RID: 34771 RVA: 0x000402DD File Offset: 0x0003E4DD
		public unsafe Transform HeadBone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadBone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x060087D4 RID: 34772 RVA: 0x002424AC File Offset: 0x002406AC
		// (set) Token: 0x060087D5 RID: 34773 RVA: 0x000402FC File Offset: 0x0003E4FC
		public unsafe Transform NeckBone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckBone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x060087D6 RID: 34774 RVA: 0x002424DC File Offset: 0x002406DC
		// (set) Token: 0x060087D7 RID: 34775 RVA: 0x0004031B File Offset: 0x0003E51B
		public unsafe Il2CppReferenceArray<AvatarEffects> MirrorEffectsTo
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarEffects>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x060087D8 RID: 34776 RVA: 0x0024250C File Offset: 0x0024070C
		// (set) Token: 0x060087D9 RID: 34777 RVA: 0x0004033A File Offset: 0x0003E53A
		public unsafe ParticleSystem ZapParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x060087DA RID: 34778 RVA: 0x0024253C File Offset: 0x0024073C
		// (set) Token: 0x060087DB RID: 34779 RVA: 0x00040359 File Offset: 0x0003E559
		public unsafe CountdownExplosion CountdownExplosion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_CountdownExplosion);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CountdownExplosion>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_CountdownExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x060087DC RID: 34780 RVA: 0x0024256C File Offset: 0x0024076C
		// (set) Token: 0x060087DD RID: 34781 RVA: 0x00040378 File Offset: 0x0003E578
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToCull
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ObjectsToCull);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x060087DE RID: 34782 RVA: 0x0024259C File Offset: 0x0024079C
		// (set) Token: 0x060087DF RID: 34783 RVA: 0x00040397 File Offset: 0x0003E597
		public unsafe bool DisableHead
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_DisableHead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_DisableHead)) = value;
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x060087E0 RID: 34784 RVA: 0x002425C4 File Offset: 0x002407C4
		// (set) Token: 0x060087E1 RID: 34785 RVA: 0x000403B2 File Offset: 0x0003E5B2
		public unsafe AudioSourceController GurgleSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_GurgleSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_GurgleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x060087E2 RID: 34786 RVA: 0x002425F4 File Offset: 0x002407F4
		// (set) Token: 0x060087E3 RID: 34787 RVA: 0x000403D1 File Offset: 0x0003E5D1
		public unsafe AudioSourceController VomitSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x060087E4 RID: 34788 RVA: 0x00242624 File Offset: 0x00240824
		// (set) Token: 0x060087E5 RID: 34789 RVA: 0x000403F0 File Offset: 0x0003E5F0
		public unsafe AudioSourceController PoofSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_PoofSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_PoofSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x060087E6 RID: 34790 RVA: 0x00242654 File Offset: 0x00240854
		// (set) Token: 0x060087E7 RID: 34791 RVA: 0x0004040F File Offset: 0x0003E60F
		public unsafe AudioSourceController FartSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x060087E8 RID: 34792 RVA: 0x00242684 File Offset: 0x00240884
		// (set) Token: 0x060087E9 RID: 34793 RVA: 0x0004042E File Offset: 0x0003E62E
		public unsafe AudioSourceController FireSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x060087EA RID: 34794 RVA: 0x002426B4 File Offset: 0x002408B4
		// (set) Token: 0x060087EB RID: 34795 RVA: 0x0004044D File Offset: 0x0003E64D
		public unsafe AudioSourceController ZapSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x060087EC RID: 34796 RVA: 0x002426E4 File Offset: 0x002408E4
		// (set) Token: 0x060087ED RID: 34797 RVA: 0x0004046C File Offset: 0x0003E66C
		public unsafe AudioSourceController ZapLoopSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapLoopSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapLoopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x060087EE RID: 34798 RVA: 0x00242714 File Offset: 0x00240914
		// (set) Token: 0x060087EF RID: 34799 RVA: 0x0004048B File Offset: 0x0003E68B
		public unsafe FloatSmoother AdditionalWeightController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x060087F0 RID: 34800 RVA: 0x00242744 File Offset: 0x00240944
		// (set) Token: 0x060087F1 RID: 34801 RVA: 0x000404AA File Offset: 0x0003E6AA
		public unsafe FloatSmoother AdditionalGenderController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x060087F2 RID: 34802 RVA: 0x00242774 File Offset: 0x00240974
		// (set) Token: 0x060087F3 RID: 34803 RVA: 0x000404C9 File Offset: 0x0003E6C9
		public unsafe FloatSmoother HeadSizeBoost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x060087F4 RID: 34804 RVA: 0x002427A4 File Offset: 0x002409A4
		// (set) Token: 0x060087F5 RID: 34805 RVA: 0x000404E8 File Offset: 0x0003E6E8
		public unsafe FloatSmoother NeckSizeBoost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x060087F6 RID: 34806 RVA: 0x002427D4 File Offset: 0x002409D4
		// (set) Token: 0x060087F7 RID: 34807 RVA: 0x00040507 File Offset: 0x0003E707
		public unsafe ColorSmoother SkinColorSmoother
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorSmoother>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x060087F8 RID: 34808 RVA: 0x00242804 File Offset: 0x00240A04
		// (set) Token: 0x060087F9 RID: 34809 RVA: 0x00040526 File Offset: 0x0003E726
		public unsafe bool laxativeEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_laxativeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_laxativeEnabled)) = value;
			}
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x0024282C File Offset: 0x00240A2C
		// (set) Token: 0x060087FB RID: 34811 RVA: 0x00040541 File Offset: 0x0003E741
		public unsafe Color currentEmission
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_currentEmission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_currentEmission)) = value;
			}
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x060087FC RID: 34812 RVA: 0x00242854 File Offset: 0x00240A54
		// (set) Token: 0x060087FD RID: 34813 RVA: 0x0004055C File Offset: 0x0003E75C
		public unsafe Color targetEmission
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_targetEmission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_targetEmission)) = value;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x060087FE RID: 34814 RVA: 0x0024287C File Offset: 0x00240A7C
		// (set) Token: 0x060087FF RID: 34815 RVA: 0x00040577 File Offset: 0x0003E777
		public unsafe bool isCulled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_isCulled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_isCulled)) = value;
			}
		}

		// Token: 0x04005C59 RID: 23641
		private static readonly System.IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005C5A RID: 23642
		private static readonly System.IntPtr NativeFieldInfoPtr_StinkParticles;

		// Token: 0x04005C5B RID: 23643
		private static readonly System.IntPtr NativeFieldInfoPtr_VomitParticles;

		// Token: 0x04005C5C RID: 23644
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadPoofParticles;

		// Token: 0x04005C5D RID: 23645
		private static readonly System.IntPtr NativeFieldInfoPtr_FartParticles;

		// Token: 0x04005C5E RID: 23646
		private static readonly System.IntPtr NativeFieldInfoPtr_AntiGravParticles;

		// Token: 0x04005C5F RID: 23647
		private static readonly System.IntPtr NativeFieldInfoPtr_FireParticles;

		// Token: 0x04005C60 RID: 23648
		private static readonly System.IntPtr NativeFieldInfoPtr_FireLight;

		// Token: 0x04005C61 RID: 23649
		private static readonly System.IntPtr NativeFieldInfoPtr_FoggyEffects;

		// Token: 0x04005C62 RID: 23650
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005C63 RID: 23651
		private static readonly System.IntPtr NativeFieldInfoPtr_NeckBone;

		// Token: 0x04005C64 RID: 23652
		private static readonly System.IntPtr NativeFieldInfoPtr_MirrorEffectsTo;

		// Token: 0x04005C65 RID: 23653
		private static readonly System.IntPtr NativeFieldInfoPtr_ZapParticles;

		// Token: 0x04005C66 RID: 23654
		private static readonly System.IntPtr NativeFieldInfoPtr_CountdownExplosion;

		// Token: 0x04005C67 RID: 23655
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectsToCull;

		// Token: 0x04005C68 RID: 23656
		private static readonly System.IntPtr NativeFieldInfoPtr_DisableHead;

		// Token: 0x04005C69 RID: 23657
		private static readonly System.IntPtr NativeFieldInfoPtr_GurgleSound;

		// Token: 0x04005C6A RID: 23658
		private static readonly System.IntPtr NativeFieldInfoPtr_VomitSound;

		// Token: 0x04005C6B RID: 23659
		private static readonly System.IntPtr NativeFieldInfoPtr_PoofSound;

		// Token: 0x04005C6C RID: 23660
		private static readonly System.IntPtr NativeFieldInfoPtr_FartSound;

		// Token: 0x04005C6D RID: 23661
		private static readonly System.IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005C6E RID: 23662
		private static readonly System.IntPtr NativeFieldInfoPtr_ZapSound;

		// Token: 0x04005C6F RID: 23663
		private static readonly System.IntPtr NativeFieldInfoPtr_ZapLoopSound;

		// Token: 0x04005C70 RID: 23664
		private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalWeightController;

		// Token: 0x04005C71 RID: 23665
		private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalGenderController;

		// Token: 0x04005C72 RID: 23666
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadSizeBoost;

		// Token: 0x04005C73 RID: 23667
		private static readonly System.IntPtr NativeFieldInfoPtr_NeckSizeBoost;

		// Token: 0x04005C74 RID: 23668
		private static readonly System.IntPtr NativeFieldInfoPtr_SkinColorSmoother;

		// Token: 0x04005C75 RID: 23669
		private static readonly System.IntPtr NativeFieldInfoPtr_laxativeEnabled;

		// Token: 0x04005C76 RID: 23670
		private static readonly System.IntPtr NativeFieldInfoPtr_currentEmission;

		// Token: 0x04005C77 RID: 23671
		private static readonly System.IntPtr NativeFieldInfoPtr_targetEmission;

		// Token: 0x04005C78 RID: 23672
		private static readonly System.IntPtr NativeFieldInfoPtr_isCulled;

		// Token: 0x04005C79 RID: 23673
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005C7A RID: 23674
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04005C7B RID: 23675
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0;

		// Token: 0x04005C7C RID: 23676
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C7D RID: 23677
		private static readonly System.IntPtr NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0;

		// Token: 0x04005C7E RID: 23678
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C7F RID: 23679
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C80 RID: 23680
		private static readonly System.IntPtr NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0;

		// Token: 0x04005C81 RID: 23681
		private static readonly System.IntPtr NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C82 RID: 23682
		private static readonly System.IntPtr NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0;

		// Token: 0x04005C83 RID: 23683
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0;

		// Token: 0x04005C84 RID: 23684
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0;

		// Token: 0x04005C85 RID: 23685
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0;

		// Token: 0x04005C86 RID: 23686
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0;

		// Token: 0x04005C87 RID: 23687
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0;

		// Token: 0x04005C88 RID: 23688
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0;

		// Token: 0x04005C89 RID: 23689
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0;

		// Token: 0x04005C8A RID: 23690
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C8B RID: 23691
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C8C RID: 23692
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C8D RID: 23693
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C8E RID: 23694
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0;

		// Token: 0x04005C8F RID: 23695
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0;

		// Token: 0x04005C90 RID: 23696
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C91 RID: 23697
		private static readonly System.IntPtr NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0;

		// Token: 0x04005C92 RID: 23698
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0;

		// Token: 0x04005C93 RID: 23699
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0;

		// Token: 0x04005C94 RID: 23700
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0;

		// Token: 0x04005C95 RID: 23701
		private static readonly System.IntPtr NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0;

		// Token: 0x04005C96 RID: 23702
		private static readonly System.IntPtr NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0;

		// Token: 0x04005C97 RID: 23703
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C98 RID: 23704
		private static readonly System.IntPtr NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005C99 RID: 23705
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005C9A RID: 23706
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_0_Private_Void_0;

		// Token: 0x04005C9B RID: 23707
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005C9C RID: 23708
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000B39 RID: 2873
		[ObfuscatedName("ScheduleOne.AvatarFramework.AvatarEffects+<<EnableLaxative>g__Routine|47_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA92 RID: 55954 RVA: 0x00343B68 File Offset: 0x00341D68
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "<<EnableLaxative>g__Routine|47_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680374);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680375);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680376);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680377);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680378);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680379);
			}

			// Token: 0x0600DA93 RID: 55955 RVA: 0x00343C48 File Offset: 0x00341E48
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA94 RID: 55956 RVA: 0x00343C90 File Offset: 0x00341E90
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA95 RID: 55957 RVA: 0x00343CC4 File Offset: 0x00341EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253979, XrefRangeEnd = 253987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700436E RID: 17262
			// (get) Token: 0x0600DA96 RID: 55958 RVA: 0x00343D00 File Offset: 0x00341F00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA97 RID: 55959 RVA: 0x00343D40 File Offset: 0x00341F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253987, XrefRangeEnd = 253992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700436F RID: 17263
			// (get) Token: 0x0600DA98 RID: 55960 RVA: 0x00343D74 File Offset: 0x00341F74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA99 RID: 55961 RVA: 0x0006A023 File Offset: 0x00068223
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700436B RID: 17259
			// (get) Token: 0x0600DA9A RID: 55962 RVA: 0x00343DB4 File Offset: 0x00341FB4
			// (set) Token: 0x0600DA9B RID: 55963 RVA: 0x0006A02C File Offset: 0x0006822C
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700436C RID: 17260
			// (get) Token: 0x0600DA9C RID: 55964 RVA: 0x00343DDC File Offset: 0x00341FDC
			// (set) Token: 0x0600DA9D RID: 55965 RVA: 0x0006A047 File Offset: 0x00068247
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436D RID: 17261
			// (get) Token: 0x0600DA9E RID: 55966 RVA: 0x00343E0C File Offset: 0x0034200C
			// (set) Token: 0x0600DA9F RID: 55967 RVA: 0x0006A066 File Offset: 0x00068266
			public unsafe AvatarEffects __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400931C RID: 37660
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400931D RID: 37661
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400931E RID: 37662
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400931F RID: 37663
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009320 RID: 37664
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009321 RID: 37665
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009322 RID: 37666
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009323 RID: 37667
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009324 RID: 37668
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B3A RID: 2874
		[ObfuscatedName("ScheduleOne.AvatarFramework.AvatarEffects+<<TriggerSick>g__Routine|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600DAA0 RID: 55968 RVA: 0x00343E3C File Offset: 0x0034203C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "<<TriggerSick>g__Routine|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680380);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680381);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680382);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680383);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680384);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680385);
			}

			// Token: 0x0600DAA1 RID: 55969 RVA: 0x00343F1C File Offset: 0x0034211C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DAA2 RID: 55970 RVA: 0x00343F64 File Offset: 0x00342164
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DAA3 RID: 55971 RVA: 0x00343F98 File Offset: 0x00342198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253992, XrefRangeEnd = 253998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004373 RID: 17267
			// (get) Token: 0x0600DAA4 RID: 55972 RVA: 0x00343FD4 File Offset: 0x003421D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DAA5 RID: 55973 RVA: 0x00344014 File Offset: 0x00342214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253998, XrefRangeEnd = 254003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004374 RID: 17268
			// (get) Token: 0x0600DAA6 RID: 55974 RVA: 0x00344048 File Offset: 0x00342248
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DAA7 RID: 55975 RVA: 0x0006A085 File Offset: 0x00068285
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004370 RID: 17264
			// (get) Token: 0x0600DAA8 RID: 55976 RVA: 0x00344088 File Offset: 0x00342288
			// (set) Token: 0x0600DAA9 RID: 55977 RVA: 0x0006A08E File Offset: 0x0006828E
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004371 RID: 17265
			// (get) Token: 0x0600DAAA RID: 55978 RVA: 0x003440B0 File Offset: 0x003422B0
			// (set) Token: 0x0600DAAB RID: 55979 RVA: 0x0006A0A9 File Offset: 0x000682A9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004372 RID: 17266
			// (get) Token: 0x0600DAAC RID: 55980 RVA: 0x003440E0 File Offset: 0x003422E0
			// (set) Token: 0x0600DAAD RID: 55981 RVA: 0x0006A0C8 File Offset: 0x000682C8
			public unsafe AvatarEffects __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009325 RID: 37669
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009326 RID: 37670
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009327 RID: 37671
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009328 RID: 37672
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009329 RID: 37673
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400932A RID: 37674
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400932B RID: 37675
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400932C RID: 37676
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400932D RID: 37677
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
