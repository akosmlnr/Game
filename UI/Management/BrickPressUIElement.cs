using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006FC RID: 1788
	public class BrickPressUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A016 RID: 40982 RVA: 0x00289E44 File Offset: 0x00288044
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressUIElement()
		{
			Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BrickPressUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr);
			BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, "<AssignedPress>k__BackingField");
			BrickPressUIElement.NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100683030);
			BrickPressUIElement.NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100683031);
			BrickPressUIElement.NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100683032);
			BrickPressUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100683033);
			BrickPressUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100683034);
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0600A017 RID: 40983 RVA: 0x00289EEC File Offset: 0x002880EC
		// (set) Token: 0x0600A018 RID: 40984 RVA: 0x00289F2C File Offset: 0x0028812C
		public unsafe BrickPress AssignedPress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x00289F70 File Offset: 0x00288170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283954, RefRangeEnd = 283955, XrefRangeStart = 283944, XrefRangeEnd = 283954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A01A RID: 40986 RVA: 0x00289FB4 File Offset: 0x002881B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283955, XrefRangeEnd = 283960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A01B RID: 40987 RVA: 0x00289FF0 File Offset: 0x002881F0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A01C RID: 40988 RVA: 0x0004E576 File Offset: 0x0004C776
		public BrickPressUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0600A01D RID: 40989 RVA: 0x0028A02C File Offset: 0x0028822C
		// (set) Token: 0x0600A01E RID: 40990 RVA: 0x0004E57F File Offset: 0x0004C77F
		public unsafe BrickPress _AssignedPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B82 RID: 27522
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPress_k__BackingField;

		// Token: 0x04006B83 RID: 27523
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0;

		// Token: 0x04006B84 RID: 27524
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0;

		// Token: 0x04006B85 RID: 27525
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0;

		// Token: 0x04006B86 RID: 27526
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006B87 RID: 27527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
