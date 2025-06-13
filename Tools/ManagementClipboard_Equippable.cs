using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.UI.Management;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054B RID: 1355
	public class ManagementClipboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007824 RID: 30756 RVA: 0x0020CEC8 File Offset: 0x0020B0C8
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementClipboard_Equippable()
		{
			Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ManagementClipboard_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr);
			ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "Clipboard");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "LoweredPosition");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "RaisedPosition");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "Light");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "SelectionInfo");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "OverrideText");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "moveRoutine");
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678530);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678531);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678532);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678533);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678534);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678535);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_EndOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678536);
			ManagementClipboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678537);
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x0020D024 File Offset: 0x0020B224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234186, XrefRangeEnd = 234236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x0020D074 File Offset: 0x0020B274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234236, XrefRangeEnd = 234271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x0020D0B0 File Offset: 0x0020B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234271, XrefRangeEnd = 234319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x0020D0EC File Offset: 0x0020B2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234319, XrefRangeEnd = 234337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullscreenEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x0020D120 File Offset: 0x0020B320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234337, XrefRangeEnd = 234356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullscreenExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x0020D154 File Offset: 0x0020B354
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234361, RefRangeEnd = 234364, XrefRangeStart = 234356, XrefRangeEnd = 234361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideClipboardText(string overriddenText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(overriddenText);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x0020D198 File Offset: 0x0020B398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234369, RefRangeEnd = 234372, XrefRangeStart = 234364, XrefRangeEnd = 234369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_EndOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x0020D1CC File Offset: 0x0020B3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementClipboard_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00038AD6 File Offset: 0x00036CD6
		public ManagementClipboard_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600782E RID: 30766 RVA: 0x0020D208 File Offset: 0x0020B408
		// (set) Token: 0x0600782F RID: 30767 RVA: 0x00038ADF File Offset: 0x00036CDF
		public unsafe Transform Clipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x06007830 RID: 30768 RVA: 0x0020D238 File Offset: 0x0020B438
		// (set) Token: 0x06007831 RID: 30769 RVA: 0x00038AFE File Offset: 0x00036CFE
		public unsafe Transform LoweredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x06007832 RID: 30770 RVA: 0x0020D268 File Offset: 0x0020B468
		// (set) Token: 0x06007833 RID: 30771 RVA: 0x00038B1D File Offset: 0x00036D1D
		public unsafe Transform RaisedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x06007834 RID: 30772 RVA: 0x0020D298 File Offset: 0x0020B498
		// (set) Token: 0x06007835 RID: 30773 RVA: 0x00038B3C File Offset: 0x00036D3C
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x06007836 RID: 30774 RVA: 0x0020D2C8 File Offset: 0x0020B4C8
		// (set) Token: 0x06007837 RID: 30775 RVA: 0x00038B5B File Offset: 0x00036D5B
		public unsafe SelectionInfoUI SelectionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionInfoUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x06007838 RID: 30776 RVA: 0x0020D2F8 File Offset: 0x0020B4F8
		// (set) Token: 0x06007839 RID: 30777 RVA: 0x00038B7A File Offset: 0x00036D7A
		public unsafe TextMeshProUGUI OverrideText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x0600783A RID: 30778 RVA: 0x0020D328 File Offset: 0x0020B528
		// (set) Token: 0x0600783B RID: 30779 RVA: 0x00038B99 File Offset: 0x00036D99
		public unsafe Coroutine moveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400521D RID: 21021
		private static readonly IntPtr NativeFieldInfoPtr_Clipboard;

		// Token: 0x0400521E RID: 21022
		private static readonly IntPtr NativeFieldInfoPtr_LoweredPosition;

		// Token: 0x0400521F RID: 21023
		private static readonly IntPtr NativeFieldInfoPtr_RaisedPosition;

		// Token: 0x04005220 RID: 21024
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04005221 RID: 21025
		private static readonly IntPtr NativeFieldInfoPtr_SelectionInfo;

		// Token: 0x04005222 RID: 21026
		private static readonly IntPtr NativeFieldInfoPtr_OverrideText;

		// Token: 0x04005223 RID: 21027
		private static readonly IntPtr NativeFieldInfoPtr_moveRoutine;

		// Token: 0x04005224 RID: 21028
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005225 RID: 21029
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005226 RID: 21030
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005227 RID: 21031
		private static readonly IntPtr NativeMethodInfoPtr_FullscreenEnter_Private_Void_0;

		// Token: 0x04005228 RID: 21032
		private static readonly IntPtr NativeMethodInfoPtr_FullscreenExit_Private_Void_0;

		// Token: 0x04005229 RID: 21033
		private static readonly IntPtr NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0;

		// Token: 0x0400522A RID: 21034
		private static readonly IntPtr NativeMethodInfoPtr_EndOverride_Public_Void_0;

		// Token: 0x0400522B RID: 21035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
