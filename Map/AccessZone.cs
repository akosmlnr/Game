using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200079D RID: 1949
	public class AccessZone : MonoBehaviour
	{
		// Token: 0x0600B8BB RID: 47291 RVA: 0x002E2218 File Offset: 0x002E0418
		// Note: this type is marked as 'beforefieldinit'.
		static AccessZone()
		{
			Il2CppClassPointerStore<AccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "AccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessZone>.NativeClassPtr);
			AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "<IsOpen>k__BackingField");
			AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "AllowExitWhenClosed");
			AccessZone.NativeFieldInfoPtr_AutoCloseDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "AutoCloseDoor");
			AccessZone.NativeFieldInfoPtr_Doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "Doors");
			AccessZone.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "Lights");
			AccessZone.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "onOpen");
			AccessZone.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "onClose");
			AccessZone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100686174);
			AccessZone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100686175);
			AccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100686176);
			AccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100686177);
			AccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100686178);
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600B8BC RID: 47292 RVA: 0x002E2338 File Offset: 0x002E0538
		// (set) Token: 0x0600B8BD RID: 47293 RVA: 0x002E2374 File Offset: 0x002E0574
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B8BE RID: 47294 RVA: 0x002E23B4 File Offset: 0x002E05B4
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8BF RID: 47295 RVA: 0x002E23F0 File Offset: 0x002E05F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315781, RefRangeEnd = 315782, XrefRangeStart = 315773, XrefRangeEnd = 315781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x002E243C File Offset: 0x002E063C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315782, XrefRangeEnd = 315783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x0005A41B File Offset: 0x0005861B
		public AccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600B8C2 RID: 47298 RVA: 0x002E2478 File Offset: 0x002E0678
		// (set) Token: 0x0600B8C3 RID: 47299 RVA: 0x0005A424 File Offset: 0x00058624
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600B8C4 RID: 47300 RVA: 0x002E24A0 File Offset: 0x002E06A0
		// (set) Token: 0x0600B8C5 RID: 47301 RVA: 0x0005A43F File Offset: 0x0005863F
		public unsafe bool AllowExitWhenClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed)) = value;
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600B8C6 RID: 47302 RVA: 0x002E24C8 File Offset: 0x002E06C8
		// (set) Token: 0x0600B8C7 RID: 47303 RVA: 0x0005A45A File Offset: 0x0005865A
		public unsafe bool AutoCloseDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AutoCloseDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AutoCloseDoor)) = value;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600B8C8 RID: 47304 RVA: 0x002E24F0 File Offset: 0x002E06F0
		// (set) Token: 0x0600B8C9 RID: 47305 RVA: 0x0005A475 File Offset: 0x00058675
		public unsafe Il2CppReferenceArray<DoorController> Doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DoorController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600B8CA RID: 47306 RVA: 0x002E2520 File Offset: 0x002E0720
		// (set) Token: 0x0600B8CB RID: 47307 RVA: 0x0005A494 File Offset: 0x00058694
		public unsafe Il2CppReferenceArray<ToggleableLight> Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600B8CC RID: 47308 RVA: 0x002E2550 File Offset: 0x002E0750
		// (set) Token: 0x0600B8CD RID: 47309 RVA: 0x0005A4B3 File Offset: 0x000586B3
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600B8CE RID: 47310 RVA: 0x002E2580 File Offset: 0x002E0780
		// (set) Token: 0x0600B8CF RID: 47311 RVA: 0x0005A4D2 File Offset: 0x000586D2
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007CA4 RID: 31908
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007CA5 RID: 31909
		private static readonly IntPtr NativeFieldInfoPtr_AllowExitWhenClosed;

		// Token: 0x04007CA6 RID: 31910
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseDoor;

		// Token: 0x04007CA7 RID: 31911
		private static readonly IntPtr NativeFieldInfoPtr_Doors;

		// Token: 0x04007CA8 RID: 31912
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x04007CA9 RID: 31913
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04007CAA RID: 31914
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04007CAB RID: 31915
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007CAC RID: 31916
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007CAD RID: 31917
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007CAE RID: 31918
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04007CAF RID: 31919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
