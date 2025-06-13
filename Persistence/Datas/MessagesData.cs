using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000281 RID: 641
	public class MessagesData : SaveData
	{
		// Token: 0x06003072 RID: 12402 RVA: 0x000195C5 File Offset: 0x000177C5
		// Note: this type is marked as 'beforefieldinit'.
		static MessagesData()
		{
			Il2CppClassPointerStore<MessagesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MessagesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesData>.NativeClassPtr);
			MessagesData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesData>.NativeClassPtr, 100669005);
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0010E900 File Offset: 0x0010CB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136226, RefRangeEnd = 136227, XrefRangeStart = 136226, XrefRangeEnd = 136227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000195FE File Offset: 0x000177FE
		public MessagesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
