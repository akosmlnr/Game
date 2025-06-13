using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004D3 RID: 1235
	[Serializable]
	public class StringDatabase : ScriptableObject
	{
		// Token: 0x06006BB7 RID: 27575 RVA: 0x001E3BFC File Offset: 0x001E1DFC
		// Note: this type is marked as 'beforefieldinit'.
		static StringDatabase()
		{
			Il2CppClassPointerStore<StringDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "StringDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr);
			StringDatabase.NativeFieldInfoPtr_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr, "Strings");
			StringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr, 100677065);
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x001E3C54 File Offset: 0x001E1E54
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 92196, RefRangeEnd = 92208, XrefRangeStart = 92196, XrefRangeEnd = 92208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00032AF2 File Offset: 0x00030CF2
		public StringDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06006BBA RID: 27578 RVA: 0x001E3C90 File Offset: 0x001E1E90
		// (set) Token: 0x06006BBB RID: 27579 RVA: 0x00032AFB File Offset: 0x00030CFB
		public unsafe Il2CppStringArray Strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDatabase.NativeFieldInfoPtr_Strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDatabase.NativeFieldInfoPtr_Strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049C8 RID: 18888
		private static readonly IntPtr NativeFieldInfoPtr_Strings;

		// Token: 0x040049C9 RID: 18889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
