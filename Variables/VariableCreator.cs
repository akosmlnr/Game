using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200018D RID: 397
	[System.Serializable]
	public class VariableCreator : Il2CppSystem.Object
	{
		// Token: 0x06001F32 RID: 7986 RVA: 0x000D49D8 File Offset: 0x000D2BD8
		// Note: this type is marked as 'beforefieldinit'.
		static VariableCreator()
		{
			Il2CppClassPointerStore<VariableCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "VariableCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr);
			VariableCreator.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Name");
			VariableCreator.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Type");
			VariableCreator.NativeFieldInfoPtr_InitialValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "InitialValue");
			VariableCreator.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Persistent");
			VariableCreator.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Mode");
			VariableCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, 100666858);
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000D4A80 File Offset: 0x000D2C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111011, XrefRangeEnd = 111015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0001175E File Offset: 0x0000F95E
		public VariableCreator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000D4ABC File Offset: 0x000D2CBC
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x00011767 File Offset: 0x0000F967
		public unsafe string Name
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x000D4AE4 File Offset: 0x000D2CE4
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x00011786 File Offset: 0x0000F986
		public unsafe VariableDatabase.EVariableType Type
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x000D4B0C File Offset: 0x000D2D0C
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x000117A1 File Offset: 0x0000F9A1
		public unsafe string InitialValue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_InitialValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_InitialValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x000D4B34 File Offset: 0x000D2D34
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x000117C0 File Offset: 0x0000F9C0
		public unsafe bool Persistent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Persistent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Persistent)) = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x000D4B5C File Offset: 0x000D2D5C
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x000117DB File Offset: 0x0000F9DB
		public unsafe EVariableMode Mode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Mode)) = value;
			}
		}

		// Token: 0x040014B8 RID: 5304
		private static readonly System.IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040014B9 RID: 5305
		private static readonly System.IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040014BA RID: 5306
		private static readonly System.IntPtr NativeFieldInfoPtr_InitialValue;

		// Token: 0x040014BB RID: 5307
		private static readonly System.IntPtr NativeFieldInfoPtr_Persistent;

		// Token: 0x040014BC RID: 5308
		private static readonly System.IntPtr NativeFieldInfoPtr_Mode;

		// Token: 0x040014BD RID: 5309
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
