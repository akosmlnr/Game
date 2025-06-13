using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000558 RID: 1368
	public class DocumentOpener : MonoBehaviour
	{
		// Token: 0x060078C8 RID: 30920 RVA: 0x0020EC44 File Offset: 0x0020CE44
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentOpener()
		{
			Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DocumentOpener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr);
			DocumentOpener.NativeFieldInfoPtr_DocumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, "DocumentName");
			DocumentOpener.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, 100678601);
			DocumentOpener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, 100678602);
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x0020ECB0 File Offset: 0x0020CEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234811, XrefRangeEnd = 234817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentOpener.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x0020ECE4 File Offset: 0x0020CEE4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentOpener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentOpener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x00038FF4 File Offset: 0x000371F4
		public DocumentOpener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x060078CC RID: 30924 RVA: 0x0020ED20 File Offset: 0x0020CF20
		// (set) Token: 0x060078CD RID: 30925 RVA: 0x00038FFD File Offset: 0x000371FD
		public unsafe string DocumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentOpener.NativeFieldInfoPtr_DocumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentOpener.NativeFieldInfoPtr_DocumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400527D RID: 21117
		private static readonly IntPtr NativeFieldInfoPtr_DocumentName;

		// Token: 0x0400527E RID: 21118
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400527F RID: 21119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
