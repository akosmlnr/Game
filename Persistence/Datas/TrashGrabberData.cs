using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000286 RID: 646
	[Serializable]
	public class TrashGrabberData : ItemData
	{
		// Token: 0x0600308B RID: 12427 RVA: 0x0010ED04 File Offset: 0x0010CF04
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberData()
		{
			Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashGrabberData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr);
			TrashGrabberData.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr, "Content");
			TrashGrabberData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr, 100669010);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x0010ED5C File Offset: 0x0010CF5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136480, RefRangeEnd = 136486, XrefRangeStart = 136480, XrefRangeEnd = 136486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberData(string iD, int quantity, TrashContentData content) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000196F3 File Offset: 0x000178F3
		public TrashGrabberData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x0010EDC8 File Offset: 0x0010CFC8
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x000196FC File Offset: 0x000178FC
		public unsafe TrashContentData Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberData.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberData.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0;
	}
}
