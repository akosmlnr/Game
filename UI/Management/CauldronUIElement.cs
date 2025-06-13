using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006FD RID: 1789
	public class CauldronUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A01F RID: 40991 RVA: 0x0028A05C File Offset: 0x0028825C
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronUIElement()
		{
			Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CauldronUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr);
			CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, "<AssignedCauldron>k__BackingField");
			CauldronUIElement.NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100683035);
			CauldronUIElement.NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100683036);
			CauldronUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100683037);
			CauldronUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100683038);
			CauldronUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100683039);
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x0028A104 File Offset: 0x00288304
		// (set) Token: 0x0600A021 RID: 40993 RVA: 0x0028A144 File Offset: 0x00288344
		public unsafe Cauldron AssignedCauldron
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x0028A188 File Offset: 0x00288388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283970, RefRangeEnd = 283971, XrefRangeStart = 283960, XrefRangeEnd = 283970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cauldron cauldron)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x0028A1CC File Offset: 0x002883CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283971, XrefRangeEnd = 283976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x0028A208 File Offset: 0x00288408
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x0004E59E File Offset: 0x0004C79E
		public CauldronUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0600A026 RID: 40998 RVA: 0x0028A244 File Offset: 0x00288444
		// (set) Token: 0x0600A027 RID: 40999 RVA: 0x0004E5A7 File Offset: 0x0004C7A7
		public unsafe Cauldron _AssignedCauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B88 RID: 27528
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCauldron_k__BackingField;

		// Token: 0x04006B89 RID: 27529
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0;

		// Token: 0x04006B8A RID: 27530
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0;

		// Token: 0x04006B8B RID: 27531
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0;

		// Token: 0x04006B8C RID: 27532
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006B8D RID: 27533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
