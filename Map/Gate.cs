using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A6 RID: 1958
	public class Gate : MonoBehaviour
	{
		// Token: 0x0600B94F RID: 47439 RVA: 0x002E3EB8 File Offset: 0x002E20B8
		// Note: this type is marked as 'beforefieldinit'.
		static Gate()
		{
			Il2CppClassPointerStore<Gate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Gate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gate>.NativeClassPtr);
			Gate.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "<IsOpen>k__BackingField");
			Gate.NativeFieldInfoPtr_Gate1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1");
			Gate.NativeFieldInfoPtr_Gate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1Open");
			Gate.NativeFieldInfoPtr_Gate1Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1Closed");
			Gate.NativeFieldInfoPtr_Gate2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2");
			Gate.NativeFieldInfoPtr_Gate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2Open");
			Gate.NativeFieldInfoPtr_Gate2Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2Closed");
			Gate.NativeFieldInfoPtr_OpenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "OpenSpeed");
			Gate.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Acceleration");
			Gate.NativeFieldInfoPtr_StartSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "StartSounds");
			Gate.NativeFieldInfoPtr_LoopSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "LoopSounds");
			Gate.NativeFieldInfoPtr_StopSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "StopSounds");
			Gate.NativeFieldInfoPtr_Momentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Momentum");
			Gate.NativeFieldInfoPtr_openDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "openDelta");
			Gate.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100686237);
			Gate.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100686238);
			Gate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100686239);
			Gate.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100686240);
			Gate.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100686241);
			Gate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100686242);
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0600B950 RID: 47440 RVA: 0x002E4078 File Offset: 0x002E2278
		// (set) Token: 0x0600B951 RID: 47441 RVA: 0x002E40B4 File Offset: 0x002E22B4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B952 RID: 47442 RVA: 0x002E40F4 File Offset: 0x002E22F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316268, XrefRangeEnd = 316287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B953 RID: 47443 RVA: 0x002E4128 File Offset: 0x002E2328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316287, XrefRangeEnd = 316288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B954 RID: 47444 RVA: 0x002E415C File Offset: 0x002E235C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316288, XrefRangeEnd = 316289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B955 RID: 47445 RVA: 0x002E4190 File Offset: 0x002E2390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316289, XrefRangeEnd = 316290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gate>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x0005A8C6 File Offset: 0x00058AC6
		public Gate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0600B957 RID: 47447 RVA: 0x002E41CC File Offset: 0x002E23CC
		// (set) Token: 0x0600B958 RID: 47448 RVA: 0x0005A8CF File Offset: 0x00058ACF
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0600B959 RID: 47449 RVA: 0x002E41F4 File Offset: 0x002E23F4
		// (set) Token: 0x0600B95A RID: 47450 RVA: 0x0005A8EA File Offset: 0x00058AEA
		public unsafe Transform Gate1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0600B95B RID: 47451 RVA: 0x002E4224 File Offset: 0x002E2424
		// (set) Token: 0x0600B95C RID: 47452 RVA: 0x0005A909 File Offset: 0x00058B09
		public unsafe Vector3 Gate1Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Open)) = value;
			}
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0600B95D RID: 47453 RVA: 0x002E424C File Offset: 0x002E244C
		// (set) Token: 0x0600B95E RID: 47454 RVA: 0x0005A924 File Offset: 0x00058B24
		public unsafe Vector3 Gate1Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Closed)) = value;
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0600B95F RID: 47455 RVA: 0x002E4274 File Offset: 0x002E2474
		// (set) Token: 0x0600B960 RID: 47456 RVA: 0x0005A93F File Offset: 0x00058B3F
		public unsafe Transform Gate2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0600B961 RID: 47457 RVA: 0x002E42A4 File Offset: 0x002E24A4
		// (set) Token: 0x0600B962 RID: 47458 RVA: 0x0005A95E File Offset: 0x00058B5E
		public unsafe Vector3 Gate2Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Open)) = value;
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0600B963 RID: 47459 RVA: 0x002E42CC File Offset: 0x002E24CC
		// (set) Token: 0x0600B964 RID: 47460 RVA: 0x0005A979 File Offset: 0x00058B79
		public unsafe Vector3 Gate2Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Closed)) = value;
			}
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0600B965 RID: 47461 RVA: 0x002E42F4 File Offset: 0x002E24F4
		// (set) Token: 0x0600B966 RID: 47462 RVA: 0x0005A994 File Offset: 0x00058B94
		public unsafe float OpenSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_OpenSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_OpenSpeed)) = value;
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0600B967 RID: 47463 RVA: 0x002E431C File Offset: 0x002E251C
		// (set) Token: 0x0600B968 RID: 47464 RVA: 0x0005A9AF File Offset: 0x00058BAF
		public unsafe float Acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Acceleration)) = value;
			}
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0600B969 RID: 47465 RVA: 0x002E4344 File Offset: 0x002E2544
		// (set) Token: 0x0600B96A RID: 47466 RVA: 0x0005A9CA File Offset: 0x00058BCA
		public unsafe Il2CppReferenceArray<AudioSourceController> StartSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StartSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StartSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0600B96B RID: 47467 RVA: 0x002E4374 File Offset: 0x002E2574
		// (set) Token: 0x0600B96C RID: 47468 RVA: 0x0005A9E9 File Offset: 0x00058BE9
		public unsafe Il2CppReferenceArray<AudioSourceController> LoopSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_LoopSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_LoopSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0600B96D RID: 47469 RVA: 0x002E43A4 File Offset: 0x002E25A4
		// (set) Token: 0x0600B96E RID: 47470 RVA: 0x0005AA08 File Offset: 0x00058C08
		public unsafe Il2CppReferenceArray<AudioSourceController> StopSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StopSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StopSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0600B96F RID: 47471 RVA: 0x002E43D4 File Offset: 0x002E25D4
		// (set) Token: 0x0600B970 RID: 47472 RVA: 0x0005AA27 File Offset: 0x00058C27
		public unsafe float Momentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Momentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Momentum)) = value;
			}
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0600B971 RID: 47473 RVA: 0x002E43FC File Offset: 0x002E25FC
		// (set) Token: 0x0600B972 RID: 47474 RVA: 0x0005AA42 File Offset: 0x00058C42
		public unsafe float openDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_openDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_openDelta)) = value;
			}
		}

		// Token: 0x04007D08 RID: 32008
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007D09 RID: 32009
		private static readonly IntPtr NativeFieldInfoPtr_Gate1;

		// Token: 0x04007D0A RID: 32010
		private static readonly IntPtr NativeFieldInfoPtr_Gate1Open;

		// Token: 0x04007D0B RID: 32011
		private static readonly IntPtr NativeFieldInfoPtr_Gate1Closed;

		// Token: 0x04007D0C RID: 32012
		private static readonly IntPtr NativeFieldInfoPtr_Gate2;

		// Token: 0x04007D0D RID: 32013
		private static readonly IntPtr NativeFieldInfoPtr_Gate2Open;

		// Token: 0x04007D0E RID: 32014
		private static readonly IntPtr NativeFieldInfoPtr_Gate2Closed;

		// Token: 0x04007D0F RID: 32015
		private static readonly IntPtr NativeFieldInfoPtr_OpenSpeed;

		// Token: 0x04007D10 RID: 32016
		private static readonly IntPtr NativeFieldInfoPtr_Acceleration;

		// Token: 0x04007D11 RID: 32017
		private static readonly IntPtr NativeFieldInfoPtr_StartSounds;

		// Token: 0x04007D12 RID: 32018
		private static readonly IntPtr NativeFieldInfoPtr_LoopSounds;

		// Token: 0x04007D13 RID: 32019
		private static readonly IntPtr NativeFieldInfoPtr_StopSounds;

		// Token: 0x04007D14 RID: 32020
		private static readonly IntPtr NativeFieldInfoPtr_Momentum;

		// Token: 0x04007D15 RID: 32021
		private static readonly IntPtr NativeFieldInfoPtr_openDelta;

		// Token: 0x04007D16 RID: 32022
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007D17 RID: 32023
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007D18 RID: 32024
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007D19 RID: 32025
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007D1A RID: 32026
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007D1B RID: 32027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
