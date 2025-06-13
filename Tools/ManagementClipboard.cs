using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054A RID: 1354
	public class ManagementClipboard : Singleton<ManagementClipboard>
	{
		// Token: 0x060077F7 RID: 30711 RVA: 0x0020C698 File Offset: 0x0020A898
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementClipboard()
		{
			Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ManagementClipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr);
			ManagementClipboard.NativeFieldInfoPtr_IsEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "IsEquipped");
			ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<IsOpen>k__BackingField");
			ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<StatePreserved>k__BackingField");
			ManagementClipboard.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OpenTime");
			ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "ClipboardTransform");
			ManagementClipboard.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OverlayCamera");
			ManagementClipboard.NativeFieldInfoPtr_OverlayLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OverlayLight");
			ManagementClipboard.NativeFieldInfoPtr_SelectionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "SelectionInfo");
			ManagementClipboard.NativeFieldInfoPtr_ClosedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "ClosedOffset");
			ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClipboardEquipped");
			ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClipboardUnequipped");
			ManagementClipboard.NativeFieldInfoPtr_onOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onOpened");
			ManagementClipboard.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClosed");
			ManagementClipboard.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "lerpRoutine");
			ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "CurrentConfigurables");
			ManagementClipboard.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678509);
			ManagementClipboard.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678510);
			ManagementClipboard.NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678511);
			ManagementClipboard.NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678512);
			ManagementClipboard.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678513);
			ManagementClipboard.NativeMethodInfoPtr_Update_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678514);
			ManagementClipboard.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678515);
			ManagementClipboard.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678516);
			ManagementClipboard.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678517);
			ManagementClipboard.NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678518);
			ManagementClipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678519);
			ManagementClipboard.NativeMethodInfoPtr__Close_b__25_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678520);
			ManagementClipboard.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100678521);
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x060077F8 RID: 30712 RVA: 0x0020C8F8 File Offset: 0x0020AAF8
		// (set) Token: 0x060077F9 RID: 30713 RVA: 0x0020C934 File Offset: 0x0020AB34
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x060077FA RID: 30714 RVA: 0x0020C974 File Offset: 0x0020AB74
		// (set) Token: 0x060077FB RID: 30715 RVA: 0x0020C9B0 File Offset: 0x0020ABB0
		public unsafe bool StatePreserved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x0020C9F0 File Offset: 0x0020ABF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233993, XrefRangeEnd = 234012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x0020CA2C File Offset: 0x0020AC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234012, XrefRangeEnd = 234022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Update_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x0020CA60 File Offset: 0x0020AC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234022, XrefRangeEnd = 234024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x0020CAA4 File Offset: 0x0020ACA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 234078, RefRangeEnd = 234082, XrefRangeStart = 234024, XrefRangeEnd = 234078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<IConfigurable> selection, ManagementClipboard_Equippable equippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equippable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x0020CAF8 File Offset: 0x0020ACF8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 234142, RefRangeEnd = 234148, XrefRangeStart = 234082, XrefRangeEnd = 234142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveState = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref preserveState;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x0020CB38 File Offset: 0x0020AD38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234167, RefRangeEnd = 234169, XrefRangeStart = 234148, XrefRangeEnd = 234167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpToVerticalPosition(bool open, Il2CppSystem.Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x0020CB88 File Offset: 0x0020AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234169, XrefRangeEnd = 234179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementClipboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x0020CBC4 File Offset: 0x0020ADC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234179, XrefRangeEnd = 234186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Close_b__25_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr__Close_b__25_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x0020CBF8 File Offset: 0x0020ADF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x0003891D File Offset: 0x00036B1D
		public ManagementClipboard(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x06007806 RID: 30726 RVA: 0x0020CC2C File Offset: 0x0020AE2C
		// (set) Token: 0x06007807 RID: 30727 RVA: 0x00038926 File Offset: 0x00036B26
		public unsafe bool IsEquipped
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_IsEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_IsEquipped)) = value;
			}
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x06007808 RID: 30728 RVA: 0x0020CC54 File Offset: 0x0020AE54
		// (set) Token: 0x06007809 RID: 30729 RVA: 0x00038941 File Offset: 0x00036B41
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x0020CC7C File Offset: 0x0020AE7C
		// (set) Token: 0x0600780B RID: 30731 RVA: 0x0003895C File Offset: 0x00036B5C
		public unsafe bool _StatePreserved_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField)) = value;
			}
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x0600780C RID: 30732 RVA: 0x0020CCA4 File Offset: 0x0020AEA4
		// (set) Token: 0x0600780D RID: 30733 RVA: 0x00038977 File Offset: 0x00036B77
		public unsafe static float OpenTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementClipboard.NativeFieldInfoPtr_OpenTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementClipboard.NativeFieldInfoPtr_OpenTime, (void*)(&value));
			}
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x0600780E RID: 30734 RVA: 0x0020CCC0 File Offset: 0x0020AEC0
		// (set) Token: 0x0600780F RID: 30735 RVA: 0x00038985 File Offset: 0x00036B85
		public unsafe Transform ClipboardTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x06007810 RID: 30736 RVA: 0x0020CCF0 File Offset: 0x0020AEF0
		// (set) Token: 0x06007811 RID: 30737 RVA: 0x000389A4 File Offset: 0x00036BA4
		public unsafe Camera OverlayCamera
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayCamera);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x06007812 RID: 30738 RVA: 0x0020CD20 File Offset: 0x0020AF20
		// (set) Token: 0x06007813 RID: 30739 RVA: 0x000389C3 File Offset: 0x00036BC3
		public unsafe Light OverlayLight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayLight);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x06007814 RID: 30740 RVA: 0x0020CD50 File Offset: 0x0020AF50
		// (set) Token: 0x06007815 RID: 30741 RVA: 0x000389E2 File Offset: 0x00036BE2
		public unsafe SelectionInfoUI SelectionInfo
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_SelectionInfo);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionInfoUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_SelectionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x06007816 RID: 30742 RVA: 0x0020CD80 File Offset: 0x0020AF80
		// (set) Token: 0x06007817 RID: 30743 RVA: 0x00038A01 File Offset: 0x00036C01
		public unsafe float ClosedOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClosedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClosedOffset)) = value;
			}
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x06007818 RID: 30744 RVA: 0x0020CDA8 File Offset: 0x0020AFA8
		// (set) Token: 0x06007819 RID: 30745 RVA: 0x00038A1C File Offset: 0x00036C1C
		public unsafe UnityEvent onClipboardEquipped
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600781A RID: 30746 RVA: 0x0020CDD8 File Offset: 0x0020AFD8
		// (set) Token: 0x0600781B RID: 30747 RVA: 0x00038A3B File Offset: 0x00036C3B
		public unsafe UnityEvent onClipboardUnequipped
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600781C RID: 30748 RVA: 0x0020CE08 File Offset: 0x0020B008
		// (set) Token: 0x0600781D RID: 30749 RVA: 0x00038A5A File Offset: 0x00036C5A
		public unsafe UnityEvent onOpened
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onOpened);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x0600781E RID: 30750 RVA: 0x0020CE38 File Offset: 0x0020B038
		// (set) Token: 0x0600781F RID: 30751 RVA: 0x00038A79 File Offset: 0x00036C79
		public unsafe UnityEvent onClosed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClosed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x06007820 RID: 30752 RVA: 0x0020CE68 File Offset: 0x0020B068
		// (set) Token: 0x06007821 RID: 30753 RVA: 0x00038A98 File Offset: 0x00036C98
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_lerpRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x06007822 RID: 30754 RVA: 0x0020CE98 File Offset: 0x0020B098
		// (set) Token: 0x06007823 RID: 30755 RVA: 0x00038AB7 File Offset: 0x00036CB7
		public unsafe List<IConfigurable> CurrentConfigurables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005201 RID: 20993
		private static readonly System.IntPtr NativeFieldInfoPtr_IsEquipped;

		// Token: 0x04005202 RID: 20994
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005203 RID: 20995
		private static readonly System.IntPtr NativeFieldInfoPtr__StatePreserved_k__BackingField;

		// Token: 0x04005204 RID: 20996
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04005205 RID: 20997
		private static readonly System.IntPtr NativeFieldInfoPtr_ClipboardTransform;

		// Token: 0x04005206 RID: 20998
		private static readonly System.IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x04005207 RID: 20999
		private static readonly System.IntPtr NativeFieldInfoPtr_OverlayLight;

		// Token: 0x04005208 RID: 21000
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectionInfo;

		// Token: 0x04005209 RID: 21001
		private static readonly System.IntPtr NativeFieldInfoPtr_ClosedOffset;

		// Token: 0x0400520A RID: 21002
		private static readonly System.IntPtr NativeFieldInfoPtr_onClipboardEquipped;

		// Token: 0x0400520B RID: 21003
		private static readonly System.IntPtr NativeFieldInfoPtr_onClipboardUnequipped;

		// Token: 0x0400520C RID: 21004
		private static readonly System.IntPtr NativeFieldInfoPtr_onOpened;

		// Token: 0x0400520D RID: 21005
		private static readonly System.IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x0400520E RID: 21006
		private static readonly System.IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x0400520F RID: 21007
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentConfigurables;

		// Token: 0x04005210 RID: 21008
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005211 RID: 21009
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005212 RID: 21010
		private static readonly System.IntPtr NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0;

		// Token: 0x04005213 RID: 21011
		private static readonly System.IntPtr NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0;

		// Token: 0x04005214 RID: 21012
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005215 RID: 21013
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_1;

		// Token: 0x04005216 RID: 21014
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005217 RID: 21015
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0;

		// Token: 0x04005218 RID: 21016
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04005219 RID: 21017
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0;

		// Token: 0x0400521A RID: 21018
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400521B RID: 21019
		private static readonly System.IntPtr NativeMethodInfoPtr__Close_b__25_0_Private_Void_1;

		// Token: 0x0400521C RID: 21020
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000AE3 RID: 2787
		[ObfuscatedName("ScheduleOne.Tools.ManagementClipboard+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7D2 RID: 55250 RVA: 0x0033BEC4 File Offset: 0x0033A0C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr);
				ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "startPos");
				ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "endPos");
				ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "callback");
				ManagementClipboard.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, 100678522);
				ManagementClipboard.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, 100678523);
			}

			// Token: 0x0600D7D3 RID: 55251 RVA: 0x0033BF68 File Offset: 0x0033A168
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7D4 RID: 55252 RVA: 0x0033BFA4 File Offset: 0x0033A1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233988, XrefRangeEnd = 233993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D7D5 RID: 55253 RVA: 0x00068BA7 File Offset: 0x00066DA7
			public __c__DisplayClass26_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042A4 RID: 17060
			// (get) Token: 0x0600D7D6 RID: 55254 RVA: 0x0033BFE4 File Offset: 0x0033A1E4
			// (set) Token: 0x0600D7D7 RID: 55255 RVA: 0x00068BB0 File Offset: 0x00066DB0
			public unsafe ManagementClipboard __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A5 RID: 17061
			// (get) Token: 0x0600D7D8 RID: 55256 RVA: 0x0033C014 File Offset: 0x0033A214
			// (set) Token: 0x0600D7D9 RID: 55257 RVA: 0x00068BCF File Offset: 0x00066DCF
			public unsafe Vector3 startPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x170042A6 RID: 17062
			// (get) Token: 0x0600D7DA RID: 55258 RVA: 0x0033C03C File Offset: 0x0033A23C
			// (set) Token: 0x0600D7DB RID: 55259 RVA: 0x00068BEA File Offset: 0x00066DEA
			public unsafe Vector3 endPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x170042A7 RID: 17063
			// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x0033C064 File Offset: 0x0033A264
			// (set) Token: 0x0600D7DD RID: 55261 RVA: 0x00068C05 File Offset: 0x00066E05
			public unsafe Il2CppSystem.Action callback
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_callback);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400918D RID: 37261
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400918E RID: 37262
			private static readonly System.IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x0400918F RID: 37263
			private static readonly System.IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04009190 RID: 37264
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04009191 RID: 37265
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009192 RID: 37266
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CBD RID: 3261
			[ObfuscatedName("ScheduleOne.Tools.ManagementClipboard+<>c__DisplayClass26_0+<<LerpToVerticalPosition>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E9CD RID: 59853 RVA: 0x0036F53C File Offset: 0x0036D73C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0>.NativeClassPtr, "<<LerpToVerticalPosition>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678524);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678525);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678526);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678527);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678528);
					ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100678529);
				}

				// Token: 0x0600E9CE RID: 59854 RVA: 0x0036F630 File Offset: 0x0036D830
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9CF RID: 59855 RVA: 0x0036F678 File Offset: 0x0036D878
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9D0 RID: 59856 RVA: 0x0036F6AC File Offset: 0x0036D8AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233973, XrefRangeEnd = 233983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700484B RID: 18507
				// (get) Token: 0x0600E9D1 RID: 59857 RVA: 0x0036F6E8 File Offset: 0x0036D8E8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9D2 RID: 59858 RVA: 0x0036F728 File Offset: 0x0036D928
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233983, XrefRangeEnd = 233988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700484C RID: 18508
				// (get) Token: 0x0600E9D3 RID: 59859 RVA: 0x0036F75C File Offset: 0x0036D95C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9D4 RID: 59860 RVA: 0x00071AFF File Offset: 0x0006FCFF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004847 RID: 18503
				// (get) Token: 0x0600E9D5 RID: 59861 RVA: 0x0036F79C File Offset: 0x0036D99C
				// (set) Token: 0x0600E9D6 RID: 59862 RVA: 0x00071B08 File Offset: 0x0006FD08
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004848 RID: 18504
				// (get) Token: 0x0600E9D7 RID: 59863 RVA: 0x0036F7C4 File Offset: 0x0036D9C4
				// (set) Token: 0x0600E9D8 RID: 59864 RVA: 0x00071B23 File Offset: 0x0006FD23
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004849 RID: 18505
				// (get) Token: 0x0600E9D9 RID: 59865 RVA: 0x0036F7F4 File Offset: 0x0036D9F4
				// (set) Token: 0x0600E9DA RID: 59866 RVA: 0x00071B42 File Offset: 0x0006FD42
				public unsafe ManagementClipboard.__c__DisplayClass26_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700484A RID: 18506
				// (get) Token: 0x0600E9DB RID: 59867 RVA: 0x0036F824 File Offset: 0x0036DA24
				// (set) Token: 0x0600E9DC RID: 59868 RVA: 0x00071B61 File Offset: 0x0006FD61
				public unsafe float _i_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009C72 RID: 40050
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C73 RID: 40051
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C74 RID: 40052
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C75 RID: 40053
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009C76 RID: 40054
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C77 RID: 40055
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C78 RID: 40056
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C79 RID: 40057
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C7A RID: 40058
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C7B RID: 40059
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
