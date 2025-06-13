using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000754 RID: 1876
	public class VMSBoard : MonoBehaviour
	{
		// Token: 0x0600A8C3 RID: 43203 RVA: 0x002A579C File Offset: 0x002A399C
		// Note: this type is marked as 'beforefieldinit'.
		static VMSBoard()
		{
			Il2CppClassPointerStore<VMSBoard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "VMSBoard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr);
			VMSBoard.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, "Label");
			VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100684037);
			VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100684038);
			VMSBoard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100684039);
		}

		// Token: 0x0600A8C4 RID: 43204 RVA: 0x002A581C File Offset: 0x002A3A1C
		[CallerCount(0)]
		public unsafe void SetText(string text, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8C5 RID: 43205 RVA: 0x002A586C File Offset: 0x002A3A6C
		[CallerCount(0)]
		public unsafe void SetText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x002A58B0 File Offset: 0x002A3AB0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VMSBoard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x00052F6B File Offset: 0x0005116B
		public VMSBoard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600A8C8 RID: 43208 RVA: 0x002A58EC File Offset: 0x002A3AEC
		// (set) Token: 0x0600A8C9 RID: 43209 RVA: 0x00052F74 File Offset: 0x00051174
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VMSBoard.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VMSBoard.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400712A RID: 28970
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x0400712B RID: 28971
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Color_0;

		// Token: 0x0400712C RID: 28972
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;

		// Token: 0x0400712D RID: 28973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
