using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003BF RID: 959
	public class ManagementMode : Singleton<ManagementMode>
	{
		// Token: 0x06004A0C RID: 18956 RVA: 0x0016B6CC File Offset: 0x001698CC
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementMode()
		{
			Il2CppClassPointerStore<ManagementMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr);
			ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "ManagementModeInputPrompt");
			ManagementMode.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "Canvas");
			ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "OnEnterManagementMode");
			ManagementMode.NativeFieldInfoPtr_onExitManagementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "onExitManagementMode");
			ManagementMode.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672554);
			ManagementMode.NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672555);
			ManagementMode.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672556);
			ManagementMode.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672557);
			ManagementMode.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672558);
			ManagementMode.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672559);
			ManagementMode.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672560);
			ManagementMode.NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672561);
			ManagementMode.NativeMethodInfoPtr_ExitManagementMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672562);
			ManagementMode.NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672563);
			ManagementMode.NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672564);
			ManagementMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672565);
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x0016B850 File Offset: 0x00169A50
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x0016B890 File Offset: 0x00169A90
		public unsafe Property CurrentProperty
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x0016B8D4 File Offset: 0x00169AD4
		public unsafe bool isActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167009, XrefRangeEnd = 167013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x0016B910 File Offset: 0x00169B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167013, XrefRangeEnd = 167028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementMode.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x0016B94C File Offset: 0x00169B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167028, XrefRangeEnd = 167042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x0016B980 File Offset: 0x00169B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167108, RefRangeEnd = 167109, XrefRangeStart = 167042, XrefRangeEnd = 167108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x0016B9B4 File Offset: 0x00169BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167109, XrefRangeEnd = 167115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x0016B9F8 File Offset: 0x00169BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167115, XrefRangeEnd = 167129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterManagementMode(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x0016BA3C File Offset: 0x00169C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167143, RefRangeEnd = 167145, XrefRangeStart = 167129, XrefRangeEnd = 167143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitManagementMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_ExitManagementMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x0016BA70 File Offset: 0x00169C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167145, XrefRangeEnd = 167158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanEnterManagementMode()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x0016BAA0 File Offset: 0x00169CA0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanExitManagementMode()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x0016BAD0 File Offset: 0x00169CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167158, XrefRangeEnd = 167161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementMode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x00023827 File Offset: 0x00021A27
		public ManagementMode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06004A1A RID: 18970 RVA: 0x0016BB0C File Offset: 0x00169D0C
		// (set) Token: 0x06004A1B RID: 18971 RVA: 0x00023830 File Offset: 0x00021A30
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06004A1C RID: 18972 RVA: 0x0016BB3C File Offset: 0x00169D3C
		// (set) Token: 0x06004A1D RID: 18973 RVA: 0x0002384F File Offset: 0x00021A4F
		public unsafe InputPrompt ManagementModeInputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06004A1E RID: 18974 RVA: 0x0016BB6C File Offset: 0x00169D6C
		// (set) Token: 0x06004A1F RID: 18975 RVA: 0x0002386E File Offset: 0x00021A6E
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06004A20 RID: 18976 RVA: 0x0016BB9C File Offset: 0x00169D9C
		// (set) Token: 0x06004A21 RID: 18977 RVA: 0x0002388D File Offset: 0x00021A8D
		public unsafe UnityEvent OnEnterManagementMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06004A22 RID: 18978 RVA: 0x0016BBCC File Offset: 0x00169DCC
		// (set) Token: 0x06004A23 RID: 18979 RVA: 0x000238AC File Offset: 0x00021AAC
		public unsafe UnityEvent onExitManagementMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_onExitManagementMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_onExitManagementMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeFieldInfoPtr_ManagementModeInputPrompt;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeFieldInfoPtr_OnEnterManagementMode;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeFieldInfoPtr_onExitManagementMode;

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0;

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeMethodInfoPtr_ExitManagementMode_Public_Void_0;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
