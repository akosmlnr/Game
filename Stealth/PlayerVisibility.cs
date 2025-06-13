using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using UnityEngine;

namespace Il2CppScheduleOne.Stealth
{
	// Token: 0x020001AE RID: 430
	public class PlayerVisibility : NetworkBehaviour
	{
		// Token: 0x060022BE RID: 8894 RVA: 0x000E01CC File Offset: 0x000DE3CC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerVisibility()
		{
			Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Stealth", "PlayerVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr);
			PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "MAX_VISIBLITY");
			PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "CurrentVisibility");
			PlayerVisibility.NativeFieldInfoPtr_activeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "activeAttributes");
			PlayerVisibility.NativeFieldInfoPtr_filteredAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "filteredAttributes");
			PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "visibilityCheckMask");
			PlayerVisibility.NativeFieldInfoPtr_visibilityPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "visibilityPoints");
			PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "environmentalVisibility");
			PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<HighestVisionEvent>k__BackingField");
			PlayerVisibility.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "hits");
			PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted");
			PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted");
			PlayerVisibility.NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667252);
			PlayerVisibility.NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667253);
			PlayerVisibility.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667254);
			PlayerVisibility.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667255);
			PlayerVisibility.NativeMethodInfoPtr_CalculateVisibility_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667256);
			PlayerVisibility.NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667257);
			PlayerVisibility.NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667258);
			PlayerVisibility.NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667259);
			PlayerVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667260);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667261);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667262);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667263);
			PlayerVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667264);
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000E03DC File Offset: 0x000DE5DC
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x000E041C File Offset: 0x000DE61C
		public unsafe VisionEvent HighestVisionEvent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97050, RefRangeEnd = 97051, XrefRangeStart = 97050, XrefRangeEnd = 97051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114960, XrefRangeEnd = 114961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000E0460 File Offset: 0x000DE660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114961, XrefRangeEnd = 114970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000E049C File Offset: 0x000DE69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114970, XrefRangeEnd = 114976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000E04D0 File Offset: 0x000DE6D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115071, RefRangeEnd = 115072, XrefRangeStart = 114976, XrefRangeEnd = 115071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_CalculateVisibility_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000E050C File Offset: 0x000DE70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115087, RefRangeEnd = 115088, XrefRangeStart = 115072, XrefRangeEnd = 115087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityAttribute GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000E055C File Offset: 0x000DE75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115088, XrefRangeEnd = 115093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEnvironmentalVisibilityAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000E0590 File Offset: 0x000DE790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115210, RefRangeEnd = 115212, XrefRangeStart = 115093, XrefRangeEnd = 115210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateExposureToPoint(Vector3 point, float checkRange = 50f, NPC checkingNPC = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref checkRange;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkingNPC);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000E05FC File Offset: 0x000DE7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115212, XrefRangeEnd = 115232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000E0638 File Offset: 0x000DE838
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000E0674 File Offset: 0x000DE874
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000E06B0 File Offset: 0x000DE8B0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000E06EC File Offset: 0x000DE8EC
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00013471 File Offset: 0x00011671
		public PlayerVisibility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x000E0728 File Offset: 0x000DE928
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x0001347A File Offset: 0x0001167A
		public unsafe static float MAX_VISIBLITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY, (void*)(&value));
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000E0744 File Offset: 0x000DE944
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x00013488 File Offset: 0x00011688
		public unsafe float CurrentVisibility
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility)) = value;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000E076C File Offset: 0x000DE96C
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x000134A3 File Offset: 0x000116A3
		public unsafe List<VisibilityAttribute> activeAttributes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_activeAttributes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisibilityAttribute>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_activeAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000E079C File Offset: 0x000DE99C
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x000134C2 File Offset: 0x000116C2
		public unsafe List<VisibilityAttribute> filteredAttributes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_filteredAttributes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisibilityAttribute>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_filteredAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000E07CC File Offset: 0x000DE9CC
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x000134E1 File Offset: 0x000116E1
		public unsafe LayerMask visibilityCheckMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask)) = value;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000E07F4 File Offset: 0x000DE9F4
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x000134FC File Offset: 0x000116FC
		public unsafe List<Transform> visibilityPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x000E0824 File Offset: 0x000DEA24
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x0001351B File Offset: 0x0001171B
		public unsafe VisibilityAttribute environmentalVisibility
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x000E0854 File Offset: 0x000DEA54
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x0001353A File Offset: 0x0001173A
		public unsafe VisionEvent _HighestVisionEvent_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000E0884 File Offset: 0x000DEA84
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x00013559 File Offset: 0x00011759
		public unsafe List<RaycastHit> hits
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_hits);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000E08B4 File Offset: 0x000DEAB4
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00013578 File Offset: 0x00011778
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000E08DC File Offset: 0x000DEADC
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00013593 File Offset: 0x00011793
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001722 RID: 5922
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_VISIBLITY;

		// Token: 0x04001723 RID: 5923
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentVisibility;

		// Token: 0x04001724 RID: 5924
		private static readonly System.IntPtr NativeFieldInfoPtr_activeAttributes;

		// Token: 0x04001725 RID: 5925
		private static readonly System.IntPtr NativeFieldInfoPtr_filteredAttributes;

		// Token: 0x04001726 RID: 5926
		private static readonly System.IntPtr NativeFieldInfoPtr_visibilityCheckMask;

		// Token: 0x04001727 RID: 5927
		private static readonly System.IntPtr NativeFieldInfoPtr_visibilityPoints;

		// Token: 0x04001728 RID: 5928
		private static readonly System.IntPtr NativeFieldInfoPtr_environmentalVisibility;

		// Token: 0x04001729 RID: 5929
		private static readonly System.IntPtr NativeFieldInfoPtr__HighestVisionEvent_k__BackingField;

		// Token: 0x0400172A RID: 5930
		private static readonly System.IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x0400172B RID: 5931
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400172C RID: 5932
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400172D RID: 5933
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0;

		// Token: 0x0400172E RID: 5934
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0;

		// Token: 0x0400172F RID: 5935
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04001730 RID: 5936
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04001731 RID: 5937
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateVisibility_Private_Single_0;

		// Token: 0x04001732 RID: 5938
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0;

		// Token: 0x04001733 RID: 5939
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0;

		// Token: 0x04001734 RID: 5940
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0;

		// Token: 0x04001735 RID: 5941
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001736 RID: 5942
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001737 RID: 5943
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001738 RID: 5944
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001739 RID: 5945
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020008F5 RID: 2293
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C801 RID: 51201 RVA: 0x0030ED24 File Offset: 0x0030CF24
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr);
				PlayerVisibility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_0");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_1");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_2");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_5");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_3");
				PlayerVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667266);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667267);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667268);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667269);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667270);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667271);
			}

			// Token: 0x0600C802 RID: 51202 RVA: 0x0030EE40 File Offset: 0x0030D040
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C803 RID: 51203 RVA: 0x0030EE7C File Offset: 0x0030D07C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114927, XrefRangeEnd = 114929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateVisibility_b__13_0(VisibilityAttribute a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C804 RID: 51204 RVA: 0x0030EECC File Offset: 0x0030D0CC
			[CallerCount(0)]
			public unsafe string _CalculateVisibility_b__13_1(UniqueVisibilityAttribute uva)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uva);
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600C805 RID: 51205 RVA: 0x0030EF14 File Offset: 0x0030D114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114929, XrefRangeEnd = 114933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CalculateVisibility_b__13_2(IGrouping<string, UniqueVisibilityAttribute> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600C806 RID: 51206 RVA: 0x0030EF5C File Offset: 0x0030D15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114933, XrefRangeEnd = 114951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculateVisibility_b__13_3(IGrouping<string, UniqueVisibilityAttribute> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C807 RID: 51207 RVA: 0x0030EFAC File Offset: 0x0030D1AC
			[CallerCount(0)]
			public unsafe float _CalculateVisibility_b__13_5(UniqueVisibilityAttribute uva)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uva);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C808 RID: 51208 RVA: 0x00060FFF File Offset: 0x0005F1FF
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E29 RID: 15913
			// (get) Token: 0x0600C809 RID: 51209 RVA: 0x0030EFFC File Offset: 0x0030D1FC
			// (set) Token: 0x0600C80A RID: 51210 RVA: 0x00061008 File Offset: 0x0005F208
			public unsafe static PlayerVisibility.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E2A RID: 15914
			// (get) Token: 0x0600C80B RID: 51211 RVA: 0x0030F024 File Offset: 0x0030D224
			// (set) Token: 0x0600C80C RID: 51212 RVA: 0x0006101A File Offset: 0x0005F21A
			public unsafe static Il2CppSystem.Func<VisibilityAttribute, bool> __9__13_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<VisibilityAttribute, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E2B RID: 15915
			// (get) Token: 0x0600C80D RID: 51213 RVA: 0x0030F04C File Offset: 0x0030D24C
			// (set) Token: 0x0600C80E RID: 51214 RVA: 0x0006102C File Offset: 0x0005F22C
			public unsafe static Il2CppSystem.Func<UniqueVisibilityAttribute, string> __9__13_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<UniqueVisibilityAttribute, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E2C RID: 15916
			// (get) Token: 0x0600C80F RID: 51215 RVA: 0x0030F074 File Offset: 0x0030D274
			// (set) Token: 0x0600C810 RID: 51216 RVA: 0x0006103E File Offset: 0x0005F23E
			public unsafe static Il2CppSystem.Func<IGrouping<string, UniqueVisibilityAttribute>, string> __9__13_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<IGrouping<string, UniqueVisibilityAttribute>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E2D RID: 15917
			// (get) Token: 0x0600C811 RID: 51217 RVA: 0x0030F09C File Offset: 0x0030D29C
			// (set) Token: 0x0600C812 RID: 51218 RVA: 0x00061050 File Offset: 0x0005F250
			public unsafe static Il2CppSystem.Func<UniqueVisibilityAttribute, float> __9__13_5
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<UniqueVisibilityAttribute, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E2E RID: 15918
			// (get) Token: 0x0600C813 RID: 51219 RVA: 0x0030F0C4 File Offset: 0x0030D2C4
			// (set) Token: 0x0600C814 RID: 51220 RVA: 0x00061062 File Offset: 0x0005F262
			public unsafe static Il2CppSystem.Func<IGrouping<string, UniqueVisibilityAttribute>, float> __9__13_3
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<IGrouping<string, UniqueVisibilityAttribute>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087B6 RID: 34742
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040087B7 RID: 34743
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040087B8 RID: 34744
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040087B9 RID: 34745
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x040087BA RID: 34746
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_5;

			// Token: 0x040087BB RID: 34747
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x040087BC RID: 34748
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087BD RID: 34749
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0;

			// Token: 0x040087BE RID: 34750
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0;

			// Token: 0x040087BF RID: 34751
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0;

			// Token: 0x040087C0 RID: 34752
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0;

			// Token: 0x040087C1 RID: 34753
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0;
		}

		// Token: 0x020008F6 RID: 2294
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C815 RID: 51221 RVA: 0x0030F0EC File Offset: 0x0030D2EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr);
				PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, "maxPointsChangesByUniquenessCode");
				PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, 100667272);
				PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, 100667273);
			}

			// Token: 0x0600C816 RID: 51222 RVA: 0x0030F154 File Offset: 0x0030D354
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C817 RID: 51223 RVA: 0x0030F190 File Offset: 0x0030D390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114951, XrefRangeEnd = 114956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateVisibility_b__4(VisibilityAttribute attr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C818 RID: 51224 RVA: 0x00061074 File Offset: 0x0005F274
			public __c__DisplayClass13_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E2F RID: 15919
			// (get) Token: 0x0600C819 RID: 51225 RVA: 0x0030F1E0 File Offset: 0x0030D3E0
			// (set) Token: 0x0600C81A RID: 51226 RVA: 0x0006107D File Offset: 0x0005F27D
			public unsafe Dictionary<string, float> maxPointsChangesByUniquenessCode
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087C2 RID: 34754
			private static readonly System.IntPtr NativeFieldInfoPtr_maxPointsChangesByUniquenessCode;

			// Token: 0x040087C3 RID: 34755
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087C4 RID: 34756
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0;
		}

		// Token: 0x020008F7 RID: 2295
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C81B RID: 51227 RVA: 0x0030F210 File Offset: 0x0030D410
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr);
				PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, "name");
				PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, 100667274);
				PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, 100667275);
			}

			// Token: 0x0600C81C RID: 51228 RVA: 0x0030F278 File Offset: 0x0030D478
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C81D RID: 51229 RVA: 0x0030F2B4 File Offset: 0x0030D4B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114956, XrefRangeEnd = 114960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAttribute_b__0(VisibilityAttribute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C81E RID: 51230 RVA: 0x0006109C File Offset: 0x0005F29C
			public __c__DisplayClass14_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E30 RID: 15920
			// (get) Token: 0x0600C81F RID: 51231 RVA: 0x0030F304 File Offset: 0x0030D504
			// (set) Token: 0x0600C820 RID: 51232 RVA: 0x000610A5 File Offset: 0x0005F2A5
			public unsafe string name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040087C5 RID: 34757
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040087C6 RID: 34758
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087C7 RID: 34759
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0;
		}
	}
}
