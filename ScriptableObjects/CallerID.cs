using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004D1 RID: 1233
	[Serializable]
	public class CallerID : ScriptableObject
	{
		// Token: 0x06006BA6 RID: 27558 RVA: 0x001E3968 File Offset: 0x001E1B68
		// Note: this type is marked as 'beforefieldinit'.
		static CallerID()
		{
			Il2CppClassPointerStore<CallerID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "CallerID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerID>.NativeClassPtr);
			CallerID.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerID>.NativeClassPtr, "Name");
			CallerID.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerID>.NativeClassPtr, "ProfilePicture");
			CallerID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerID>.NativeClassPtr, 100677059);
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x001E39D4 File Offset: 0x001E1BD4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 92196, RefRangeEnd = 92208, XrefRangeStart = 92196, XrefRangeEnd = 92208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallerID() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallerID>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallerID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x00032A45 File Offset: 0x00030C45
		public CallerID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06006BA9 RID: 27561 RVA: 0x001E3A10 File Offset: 0x001E1C10
		// (set) Token: 0x06006BAA RID: 27562 RVA: 0x00032A4E File Offset: 0x00030C4E
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06006BAB RID: 27563 RVA: 0x001E3A38 File Offset: 0x001E1C38
		// (set) Token: 0x06006BAC RID: 27564 RVA: 0x00032A6D File Offset: 0x00030C6D
		public unsafe Sprite ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049C0 RID: 18880
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040049C1 RID: 18881
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x040049C2 RID: 18882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
