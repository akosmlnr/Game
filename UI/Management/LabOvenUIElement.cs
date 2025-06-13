using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x02000702 RID: 1794
	public class LabOvenUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A056 RID: 41046 RVA: 0x0028AC28 File Offset: 0x00288E28
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenUIElement()
		{
			Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "LabOvenUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr);
			LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, "<AssignedOven>k__BackingField");
			LabOvenUIElement.NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100683060);
			LabOvenUIElement.NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100683061);
			LabOvenUIElement.NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100683062);
			LabOvenUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100683063);
			LabOvenUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100683064);
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x0600A057 RID: 41047 RVA: 0x0028ACD0 File Offset: 0x00288ED0
		// (set) Token: 0x0600A058 RID: 41048 RVA: 0x0028AD10 File Offset: 0x00288F10
		public unsafe LabOven AssignedOven
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x0028AD54 File Offset: 0x00288F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284081, RefRangeEnd = 284082, XrefRangeStart = 284071, XrefRangeEnd = 284081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A05A RID: 41050 RVA: 0x0028AD98 File Offset: 0x00288F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284082, XrefRangeEnd = 284087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A05B RID: 41051 RVA: 0x0028ADD4 File Offset: 0x00288FD4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A05C RID: 41052 RVA: 0x0004E701 File Offset: 0x0004C901
		public LabOvenUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0600A05D RID: 41053 RVA: 0x0028AE10 File Offset: 0x00289010
		// (set) Token: 0x0600A05E RID: 41054 RVA: 0x0004E70A File Offset: 0x0004C90A
		public unsafe LabOven _AssignedOven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BAB RID: 27563
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOven_k__BackingField;

		// Token: 0x04006BAC RID: 27564
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0;

		// Token: 0x04006BAD RID: 27565
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0;

		// Token: 0x04006BAE RID: 27566
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0;

		// Token: 0x04006BAF RID: 27567
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006BB0 RID: 27568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
