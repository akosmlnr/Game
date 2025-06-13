using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x0200070D RID: 1805
	public class JoinLocal : MonoBehaviour
	{
		// Token: 0x0600A0EA RID: 41194 RVA: 0x0028C954 File Offset: 0x0028AB54
		// Note: this type is marked as 'beforefieldinit'.
		static JoinLocal()
		{
			Il2CppClassPointerStore<JoinLocal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "JoinLocal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr);
			JoinLocal.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100683133);
			JoinLocal.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100683134);
			JoinLocal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100683135);
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x0028C9C0 File Offset: 0x0028ABC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284525, XrefRangeEnd = 284537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x0028C9F4 File Offset: 0x0028ABF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284537, XrefRangeEnd = 284545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x0028CA28 File Offset: 0x0028AC28
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinLocal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x0004EB6F File Offset: 0x0004CD6F
		public JoinLocal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006C06 RID: 27654
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006C07 RID: 27655
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006C08 RID: 27656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
